create table CarsData(
CarId int ,
CategoryId int,
ColorId int,
ModelYear int,
BrandId int,
DailyPrice int,
Description nvarchar(50)
) 
Select Description,DailyPrice
From CarsData
Where Description>=2 and DailyPrice>0;