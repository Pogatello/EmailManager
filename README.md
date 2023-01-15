This is a simple application for reading and saving emails to a database. Mock data inside soulution.

**How To Run**

**1. Setup database**

Create a new database called EmailManagerDb. (SQL server)
Adjust connection string in appSettings if needed.

**2. Migration**

Open new folder on local pc. 
Git clone this repository.
Open solution in IDE. Open Package Manger Console.
Execute Update-Database command. 

If it fails or there are other problems, backup script for creating a database along with mock/test data is inside solution

**3. Start application**

App should be good to go now.

Features
- Main component for creating new emails. It wont send an emai, it will just save it to database.
- Popup on clicking cancle button. 
- 
- History page (no paging in this app iteration). On row click opens page details.
