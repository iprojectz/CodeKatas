﻿namespace KataTicTacToe
{
	// ReSharper disable InconsistentNaming
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class GameBoardSpecs
	{
		private Game game;

		// When all your test methods start with the same name --> time to extract to a new class
		//   eg before all methods in this class were "SetupBoard_"


		[TestMethod]
		public void MarkerAreSetCorrectly()
		{
			const string initialBoard = "123" +
										"456" +
										"789";
			this.game = new Game(initialBoard, 3);

			Assert.AreEqual("1", this.game.FieldIsOccupiedWithString(0, 0));
			Assert.AreEqual("2", this.game.FieldIsOccupiedWithString(1, 0));
			Assert.AreEqual("3", this.game.FieldIsOccupiedWithString(2, 0));
			Assert.AreEqual("4", this.game.FieldIsOccupiedWithString(0, 1));
			Assert.AreEqual("5", this.game.FieldIsOccupiedWithString(1, 1));
			Assert.AreEqual("6", this.game.FieldIsOccupiedWithString(2, 1));
			Assert.AreEqual("7", this.game.FieldIsOccupiedWithString(0, 2));
			Assert.AreEqual("8", this.game.FieldIsOccupiedWithString(1, 2));
			Assert.AreEqual("9", this.game.FieldIsOccupiedWithString(2, 2));
			
		}

		[TestMethod]
		public void Row0X_Winner()
		{
			const string initialBoard = "XXX" +
			                            ".X." +
			                            "..X";
			this.game = new Game(initialBoard, 3);
			
			Assert.IsTrue(this.game.Winner == Player.P1);
		}

		[TestMethod]
		public void Row0X_ButNotAPlayer_NoWinner()
		{
			const string initialBoard = "..." +
										".X." +
										"..X";
			this.game = new Game(initialBoard, 3);

			Assert.IsTrue(this.game.Winner == Player.None);
		}

		[TestMethod]
		public void Row1X_Winner()
		{
			const string initialBoard = ".a." +
										"XXX" +
										"..X";
			this.game = new Game(initialBoard, 3);

			Assert.IsTrue(this.game.Winner == Player.P1);
		}

		[TestMethod]
		public void Row2X_Winner()
		{
			const string initialBoard = ".a." +
										"OOX" +
										"XXX";
			this.game = new Game(initialBoard, 3);

			Assert.IsTrue(this.game.Winner == Player.P1);
		}


		[TestMethod]
		public void DiagonalAllX_Winner()
		{
			const string initialBoard = "X.." +
			                            ".X." +
			                            "..X";
			this.game = new Game(initialBoard, 3);

			Assert.IsTrue(this.game.Winner == Player.P1);
		}


		[TestMethod]
		public void FieldIsOccupiedWithString_Breaks_LAWOFDEMETER()
		{
			Assert.Inconclusive();
		}


		[TestMethod]
		public void CheckBounds()
		{
			Assert.Inconclusive();

			//this.game = new Game("123", 1);

		}
	}
}
// ReSharper restore InconsistentNaming