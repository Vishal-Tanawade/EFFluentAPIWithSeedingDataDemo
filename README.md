EFFluentAPIWithSeedingDataDemo
=
- 27-April 2022
- Code First Aproach
- Seed data into database
- seed data after enable migration and before adding migartion in configuration.cs file 
- ----------------------------------------------------------------------------------------
-Migartion
=
Enable-Migrations:
Enables the migrtaion in your project by creating a configration class
Add-Migration: eg. Add-Migration 'InitializeMigration' always give name to migration
Create a new migration class as per specified name with the up() and down() method
Update-Database:
Executes the last migration file created by the Add-Migration command and applies changes to the database schema.

--------------------------------------------------------------------------------------------
DB First Aproach 
=
- select only those table which doesnot have triggers and having primary key
.edmx file
EF is a ORM Object Relational model 
SSDL-Storage Schema Defination Lang.
CSDL- Conceptual Schema Defination Lang.
CS- Collabration/bridge between SSDL and CSDL(i.e. bridge between Database and Our code) 

We can add/ delete/ update record in table  using c sharp with entity framework  without anyquery
