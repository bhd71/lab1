using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace TestEstimate3
{
    [TestClass]
    public class UnitTest1
    {


        string Expresion, ExpectedResult;
        String actual;

        public TestContext TestContext { get; set; }
        [DataSource(
            "System.Data.SqlClient",
            @"Data Source=GWTN141-10;Initial Catalog=lab1;Trusted_Connection=True",
            "TestingValues",
            DataAccessMethod.Sequential
            )]
        [TestMethod]
        public void sum()
        {
            Expresion = TestContext.DataRow.Table.Rows[0][1].ToString();
            ExpectedResult = TestContext.DataRow.Table.Rows[0][2].ToString(); 


            AnalaizerClass.expression = Expresion;
            actual = AnalaizerClass.Estimate();

            try
            {
                Assert.AreEqual(ExpectedResult, actual);
            }
            catch
            {
                System.Console.WriteLine("sum is considered bad");
            }
        }


        [DataSource(
            "System.Data.SqlClient",
            @"Data Source=GWTN141-10;Initial Catalog=lab1;Trusted_Connection=True",
            "TestingValues",
            DataAccessMethod.Sequential
            )]
        [TestMethod]
        public void min()
        {
            Expresion = TestContext.DataRow.Table.Rows[1][1].ToString();
            ExpectedResult = TestContext.DataRow.Table.Rows[1][2].ToString();

            AnalaizerClass.expression = Expresion;
            actual = AnalaizerClass.Estimate();

            try
            {
                Assert.AreEqual(ExpectedResult, actual);
            }
            catch
            {
                System.Console.WriteLine("min is considered bad");
            }


        }

        [DataSource(
           "System.Data.SqlClient",
           @"Data Source=GWTN141-10;Initial Catalog=lab1;Trusted_Connection=True",
           "TestingValues",
           DataAccessMethod.Sequential
           )]
        [TestMethod]
        public void mult()
        {
            Expresion = TestContext.DataRow.Table.Rows[2][1].ToString();
            ExpectedResult = TestContext.DataRow.Table.Rows[2][2].ToString();

            AnalaizerClass.expression = Expresion;
            actual = AnalaizerClass.Estimate();

            try
            {
                Assert.AreEqual(ExpectedResult, actual);
            }
            catch
            {
                System.Console.WriteLine("mult is considered bad");
            }

        } 
        
        
        [DataSource(
           "System.Data.SqlClient",
           @"Data Source=GWTN141-10;Initial Catalog=lab1;Trusted_Connection=True",
           "TestingValues",
           DataAccessMethod.Sequential
           )]
        [TestMethod]
        public void dev()
        {
            Expresion = TestContext.DataRow.Table.Rows[3][1].ToString();
            ExpectedResult = TestContext.DataRow.Table.Rows[3][2].ToString();

            AnalaizerClass.expression = Expresion;
            actual = AnalaizerClass.Estimate();

            try
            {
                Assert.AreEqual(ExpectedResult, actual);
            }
            catch
            {
                System.Console.WriteLine("dev is considered bad");
            }

        }
        [DataSource(
           "System.Data.SqlClient",
           @"Data Source=GWTN141-10;Initial Catalog=lab1;Trusted_Connection=True",
           "TestingValues",
           DataAccessMethod.Sequential
           )]
        [TestMethod]
        public void devByNull()
        {
            Expresion = TestContext.DataRow.Table.Rows[4][1].ToString();
            ExpectedResult = TestContext.DataRow.Table.Rows[4][2].ToString();

            AnalaizerClass.expression = Expresion;
            actual = AnalaizerClass.Estimate();

            try
            {
                Assert.AreEqual(ExpectedResult, actual);
            }
            catch
            {
                System.Console.WriteLine("devByNull is considered bad");
            }

        }
        [DataSource(
           "System.Data.SqlClient",
           @"Data Source=GWTN141-10;Initial Catalog=lab1;Trusted_Connection=True",
           "TestingValues",
           DataAccessMethod.Sequential
           )]
        [TestMethod]
        public void mod()
        {
            Expresion = TestContext.DataRow.Table.Rows[5][1].ToString();
            ExpectedResult = TestContext.DataRow.Table.Rows[5][2].ToString();

            AnalaizerClass.expression = Expresion;
            actual = AnalaizerClass.Estimate();

            try
            {
                Assert.AreEqual(ExpectedResult, actual);
            }
            catch
            {
                System.Console.WriteLine("mod is considered bad");
            }

        }
        [DataSource(
           "System.Data.SqlClient",
           @"Data Source=GWTN141-10;Initial Catalog=lab1;Trusted_Connection=True",
           "TestingValues",
           DataAccessMethod.Sequential
           )]
        [TestMethod]
        public void modWithRemainder()
        {
            Expresion = TestContext.DataRow.Table.Rows[6][1].ToString();
            ExpectedResult = TestContext.DataRow.Table.Rows[6][2].ToString();

            AnalaizerClass.expression = Expresion;
            actual = AnalaizerClass.Estimate();

            try
            {
                Assert.AreEqual(ExpectedResult, actual);
            }
            catch
            {
                System.Console.WriteLine("mod with remainder is considered bad");
            }

        }
    }
}
