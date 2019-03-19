using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tictactoeMcGillian;

namespace TicTacTest
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        //CreateBoard test
        public void TestMethod1()
        {
            //arrange
            NewForm form = new NewForm();
            //act
            form.CreateBoard();
            //assert
            Assert.IsTrue(form.pnlBoard.Visible = true);
        }

        [TestMethod()]
        //CurrentPlayer test
        public void TestMethod2()
        {
            //arrange
            string player1 = "X";
            NewForm form = new NewForm();
            //act
            form.CurrentPlayer();
            //assert
            Assert.AreEqual("X", player1);
        }

        [TestMethod()]
        //ChangePlayer test
        public void TestMethod3()
        {
            //arrange
            NewForm form = new NewForm();
            String player = "O";
            //act
            form.ChangePlayer();
            //assert
            Assert.AreEqual("O", player);

        }

        [TestMethod()]
        //MakeMove test
        public void TestMethod4()
        {
            //arrange
            NewForm form = new NewForm();
            Button btn = new Button();
            btn.Text = "";
            String player = "X";
            //act
            form.MakeMove(btn);
            //assert
            Assert.AreEqual("X", player);
        }

        [TestMethod()]
        //SpaceInUse test
        public void TestMethod5()
        {
            //arrange
            NewForm form = new NewForm();
            Button btn = new Button();
            //act
            form.SpaceInUse(btn);
            //assert
            Assert.IsTrue(btn.Enabled == false);

        }
    }
}
