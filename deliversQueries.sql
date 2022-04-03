--store procedures
use transportsdb
go

--התחברות והרשמה
-- הוספת משתמש
create proc sp_addNewUser 
	@userfirstname nvarchar(20),
	@userlastname nvarchar(20),
	@useridentity nvarchar(20),
	@postalcode nvarchar(20), 
	@email nvarchar(50),
	@userpassword nvarchar(20),
	@address nvarchar(50),
	@housenumber nvarchar(20),
	@city nvarchar(20) 
as 
begin
	insert into users (userfirstname,userlastname ,useridentity ,postalcode , email,userpassword,adress,housenumber,city)
	values (@userfirstname,@userlastname ,@useridentity ,@postalcode , @email,@userpassword,@address,@housenumber,@city)
end 
go 

--הצגת קהילות להצטרפות
create proc sp_getAllCommunities
as
begin 
	select * from communities
end
go

--הוספת בקשה להצטרפות לקהילה 
create proc sp_addAskForJoinning
	@userid int,
	@communityid int,
	@joinasamanager bit
as
insert into joincommunity (userid, communityid, joinasamanager) values (@userid @communityid @joinasamanager)

--מציאת קוד משתמש ע"י סיסמא
create proc sp_getUserByPassword
@password nvarchar(50)
as
select userid from users where userpassword=@password

--הצגת כל הקהילות שמשתמש מסוים חבר בהן
create proc sp_getAllUserCommunities
@userid int
as select * from communities where userid=@userid




--צפיה בהיסטוריות
--פונקציה שמחזירה את כל המשלוחים שנעשו ע"י משתמש מסוים
create proc getAllUserDeliversByUserId 
@userid int, @fieldname nvarchar(20)
as
begin 
	select * from  transports t where userid=@userid order by @fieldname 
end

go


--פונקציה שמחזירה את כל המשלוחים הפעילים שנעשו ע"י משתמש מסוים
create proc getAllUserDeliversByUserId 
@userid int, @fieldname nvarchar(20)
as
begin 
	select * from  transports t where userid=@userid and isactive=1 order by @fieldname 
end

go














--פונקציה שמחזירה את כל המשלוחים שנעשו בקהילה מסוימת
alter proc getCommunityDeliversById 
@communityid int
as
begin 
select * from transports t left join usercommunity u on u.userid=t.userid where [communityid]=@communityid 
end

go


--פונקציה שמחזירה את כל המשלוחים  הפעילים שנעשו ע"י משתמש מסוים
create proc getActiveUserDeliversByUserId 
@userid int
as
begin 
select * from  transports t where userid=1 and isactive = 'true'
end

go

--כל המשלוחים הפעילים בקהילה מסוימת
create proc sp_getCommunityDeliversById @communityid int
as
begin 
select * from transports where [communityid]=@communityid and isactive=1
end

declare @c nvarchar
set @c='5'
exec getCommunityDeliversById @c

go



--הוספת קהילה חדשה
create proc sp_addNewCommunity
	@communityname  nvarchar(50),
    @requiredpremit bit,
    @descriptions nvarchar(50),
    @city nvarchar(50),
    @primemanager int
as 
begin
	insert into communities (communityname,requiredpremit,descriptions, city,primemanager)
	values (@communityname,@requiredpremit,@descriptions, @city,@primemanager)
end

--קביעת תפקיד לקהילה
create proc sp_addUserRoleInCommunity
	@userid int,
	@communityid int,
	@roleid int, 
as
begin 
	insert into userJoinedCommunity (userid, communityid, roleid, joinnigdate)
	values (@userid, @communityid, @roleid,SYSDATETIME())
end