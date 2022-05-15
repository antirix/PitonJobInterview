MSSQL veri tabanında bir PitonDb oluşturduktan sonra; <br>
Add-Migration 01012020.1 -Context BaseContext -OutputDir Migrations\Sql<br>
Update-Database -Context SqlContext<br>
kodlarını Package Manager Console kısmına yazarak ilerleyebilirsiniz.
