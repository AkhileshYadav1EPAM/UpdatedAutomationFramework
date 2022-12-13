using CommonFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Test.BaseTestClass
{
    public class BaseTest : BasePage
    {
        [SetUp]
        public void Setup()
        {
            Start();
        }

        [TearDown]
        public void CleanUp()
        {
            End();
        }
    }
}
