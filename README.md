MSSQL veri tabanında bir PitonDb oluşturduktan sonra;
Add-Migration 01012020.1 -Context BaseContext -OutputDir Migrations\Sql
Update-Database -Context SqlContext
kodlarını Package Manager Console kısmına yazarak ilerleyebilirsiniz.
