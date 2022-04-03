
export interface Transport
{
    transportid:number;
    userid:number;
    communityid:number;
    beginlinetoexec:Date;
    deadlinetoexec:Date;
    packageweight:number;
    packagesize:number;
    contentsdescription:string;
    instructions:string

    confirmedbymanager:boolean
    managerInstruction:string
    foundvolunteer:boolean
    volunteerid :number;
    estimatedarrivaltime: Date;
    sourceid :number;
    destinationid :number;
    isactive:boolean
    arrive:boolean


}