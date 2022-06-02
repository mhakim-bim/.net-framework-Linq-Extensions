# .net-framework-Linq-Extensions
Additional Extensions Methods for .net framework

***WhereIf***


```csharp 
var list = new List<string>()
{
    "Mohamed","Ahmed","Mahmoud","Ali"
};

var result = list.WhereIf(true,name => name[0].Equals('M')).ToList();
 
```

you see this code a lot in your api repository methods 

```csharp
if (!string.IsNullOrEmpty(filter.Country))
{
    uslTables = uslTables.Where(a => a.InvoiceCountries
        .Any(c => c.CountryName == filter.Country));
}
```
Instead you can Use StringIsNotNullOrEmpty

```csharp
var list = new List<string>()
{
    "Mohamed","Ahmed","Mahmoud","Ali"
}.AsQueryable();

var result = list
    .WhereIfStringIsNotNullOrEmpty("",name => name[0].Equals('M'))
    .ToList();
```
