using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //AAA
            Pupil etu2 = new Pupil("etu",20,1);
            //2. Acr ==> on utilise le systeme
            etu2.AddActivity(new Activity("env dev", true));
            etu2.AddEvaluation("env dev", 'd');
            //3 Assert ==> on compare résultat obtenu et attendu

            var evaluation = etu2.GetEvaluationFor("env dev");
            Assert.AreEqual('d', evaluation);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void GetEvaluationFor_ThrowException()
        { 
            //AAA

            Pupil p = new Pupil("etu", 20, 1);
            var evaluation = p.GetEvaluationFor("env dev");
            Assert.AreEqual('d', evaluation);
        }

    }
}
