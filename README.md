# MySQL script

```sql
create database Maturita;

use Maturita;

create table Passenger
(
    ID int primary key auto_increment,
    Name varchar(64) not null,
    Surname varchar(64) not null
);
```
