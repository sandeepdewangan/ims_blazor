# Inventory Management System

## Database Setup

## SQLServer

Package:



`EntityFrameworkCore.SqlServer`

`EntityFrameworkCore.Tools`

`EntityFrameworkCore.Design`



## PostgreSQL

Package:

`Npgsql.EntityFrameworkCore.PostgreSQL`

`EntityFrameworkCore.Tools`

`EntityFrameworkCore.Design`



**Adding Migration**

`add-migration "init"`

`update-database`



**Connection String**

```json
{
  "ConnectionStrings": {
    "InventoryManagement": "Host=localhost;Port=5432;Database=ims;Username=sandeep;Password=sandeep"
  },
}
```

**Program.cs**

```csharp
builder.Services.AddDbContextFactory<IMSContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("InventoryManagement"));
});
```
