# .net-framework-Linq-Extensions
Additional Extensions Methods for .net framework

***WhereIf***
` var list = new List<string>()
            {
                "Mohamed","Ahmed","Mahmoud","Ali"
            };
            
            var result = list.WhereIf(true,name => name[0].Equals('M')).ToList();
            
            Assert.True(result.Count == 2); `
