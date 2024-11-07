create table sim
(
ID char(4) primary key,
Sosim varchar(10) not null,
Mangid char(4) not null,
NgayKichHoat date not null,
NgayHetHan date not null,
foreign key(Mangid) references Mang(Mangid)
);

create table Mang
(
Mangid char(4) primary key,
TenMang nvarchar(50) not null,
);

