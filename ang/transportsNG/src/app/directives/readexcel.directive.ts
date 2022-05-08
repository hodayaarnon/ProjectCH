import { User } from 'src/app/classes/user';
import { Directive, EventEmitter, HostListener, Output } from '@angular/core';
import { Observable, Subscriber } from 'rxjs';
import * as XLSX from 'xlsx';
import { newArray } from '@angular/compiler/src/util';

@Directive({
  selector: '[appReadexcel]',
  exportAs: 'readexcel',
})
export class ReadexcelDirective {

  constructor() { }

  excelObservable: Observable<any> | undefined;
  @Output() eventEmitter = new EventEmitter();

  //newUsers:Array<User>=new Array<User>()

  @HostListener('change', ['$event.target'])
  onChange(target: HTMLInputElement) {
    const file = target.files![0];

    this.excelObservable = new Observable((subscriber: Subscriber<any>) => {
      this.readFile(file, subscriber);
    });

    this.excelObservable.subscribe((d) => {
      this.eventEmitter.emit(d);
    });

  }

  readFile(file: File, subscriber: Subscriber<any>) {
    const fileReader = new FileReader();
    fileReader.readAsArrayBuffer(file);

    fileReader.onload = (e) => {
      const bufferArray = e!.target!.result;

      const wb: XLSX.WorkBook = XLSX.read(bufferArray, { type: 'buffer' });

      const wsname: string = wb.SheetNames[0];

      const ws: XLSX.WorkSheet = wb.Sheets[wsname];

      const data = XLSX.utils.sheet_to_json(ws);

      //subscriber.next(data);
      subscriber.next(this.readAndAddWatch(data));
      subscriber.complete();
    };
  }

  readAndAddWatch(data:any)
  {
    var newUsers:Array<User>=new Array<User>()

    newUsers=new Array<User>()
    data.forEach((element: { Userlastname: any; }) => {
      console.log(element.Userlastname);
      
    });
    for (let index = 0; index < data.length; index++) {
      console.log(data[index].Userlastname, data[index].Adresslat, data[index].Userpassword, data[index].Street)
      let u:User=new User()
        u.Userfirstname=data[index].Userfirstname,
        u.Userlastname=data[index].Userlastname,
        u.Email=data[index].Email,
        u.Userpassword=data[index].Userpassword,
        u.Useridentity=data[index].Useridentity,
        u.Postalcode=data[index].Postalcode,
        u.Street=data[index].Street,
        u.Adress=data[index].Address,
        u.Housenumber=data[index].Housenumber,
        u.Adresslng=data[index].Addresslng,
        u.Adresslat=data[index].Addresslat,
        u.City=data[index].City,



        newUsers.push(u);
      
    }
    console.log("arr:", newUsers);
    return newUsers;
  }


}
