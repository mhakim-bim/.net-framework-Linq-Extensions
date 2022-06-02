using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Dotnet_Framework_Linq_Extensions.UnitTests
{
    [TestFixture]
    public class WhereTests
    {
        [Test]
        public void WhereIf_ConditionIsTrue_ExpectedOutput()
        {
            var list = new List<string>()
            {
                "Mohamed","Ahmed","Mahmoud","Ali"
            };
            
            var result = list.WhereIf(true,name => name[0].Equals('M')).ToList();
            
            Assert.True(result.Count == 2);
        }
        
        [Test]
        public void WhereIf_ConditionIsFalse_ExpectedOutput()
        {
            var list = new List<string>()
            {
                "Mohamed","Ahmed","Mahmoud","Ali"
            };
            
            var result = list.WhereIf(false,name => name[0].Equals('M')).ToList();
            
            Assert.True(result.Count == 4);
        }
        
        [Test]
        public void WhereIf_ConditionIsFalseWithAdditionalWhere()
        {
            var list = new List<string>()
            {
                "Mohamed","Ahmed","Mahmoud","Ali"
            };
            
            var result = list
                .WhereIf(false,name => name[0].Equals('M'))
                .Where(name => name[0].Equals('A'))
                .ToList();
            
            Assert.True(result.Count == 2);
        }
        
        
    }
}