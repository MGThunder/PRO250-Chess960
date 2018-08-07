using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess;
using Chess.Figures;

namespace ChessUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Chess960_InitialSetup_KingIsBetweenTwoRooks_AssertTrue()
        {
            Figure[] pieces = new Figure[] {
                new Bishop('A', 1, true), new Bishop('B', 1, true),
                new Rook('C', 1, true), new Rook('E', 1, true),
                new Knight('F', 1, true), new Knight('G', 1, true),
                new Queen('H', 1, true), new King('D', 1, true)
            };
            int rook1 = 0;
            int rook2 = 0;
            int king = 0;
            bool rookFound = false;
            for (int i = 0; i < 8; i++)
            {
                if (pieces[i].GetType() == typeof(Rook))
                {
                    if (!rookFound)
                    {
                        rook1 = pieces[i].Xpositon;
                    }
                    else
                    {
                        rook2 = pieces[i].Xpositon;
                    }
                }
                else if (pieces[i].GetType() == typeof(King))
                {
                    king = pieces[i].Xpositon;
                }
            }
            Assert.IsTrue((rook1 < king && rook2 > king) || (rook1 > king && rook2 < king), $"{rook1}, {rook2}, {king}");
        }

        [TestMethod]
        public void Chess960_InitialSetup_KingIsBetweenTwoRooks_AssertFalse()
        {
            Figure[] pieces = new Figure[] {
                new Bishop('A', 1, true), new Bishop('B', 1, true),
                new Rook('C', 1, true), new Rook('D', 1, true),
                new Knight('F', 1, true), new Knight('G', 1, true),
                new Queen('H', 1, true), new King('E', 1, true)
            };
            int rook1 = 0;
            int rook2 = 0;
            int king = 0;
            bool rookFound = false;
            for (int i = 0; i < 8; i++)
            {
                if (pieces[i].GetType() == typeof(Rook))
                {
                    if (!rookFound)
                    {
                        rook1 = pieces[i].Xpositon;
                    }
                    else
                    {
                        rook2 = pieces[i].Xpositon;
                    }
                }
                else if (pieces[i].GetType() == typeof(King))
                {
                    king = pieces[i].Xpositon;
                }
            }
            Assert.IsFalse((rook1 < king && rook2 > king) || (rook1 > king && rook2 < king), $"{rook1}, {rook2}, {king}");
        }

        [TestMethod]
        public void Chess960_InitialSetup_BishopsAreOnDifferentColorSpaces_AssertTrue()
        {
            Figure[] pieces = new Figure[] {
                new Bishop('A', 1, true), new Bishop('B', 1, true),
                new Rook('C', 1, true), new Rook('E', 1, true),
                new Knight('F', 1, true), new Knight('G', 1, true),
                new Queen('H', 1, true), new King('D', 1, true)
            };
            int bishop1 = 0;
            int bishop2 = 0;
            int king = 0;
            bool rookFound = false;
            for (int i = 0; i < 8; i++)
            {
                if (pieces[i].GetType() == typeof(Rook))
                {
                    if (!rookFound)
                    {
                        bishop1 = pieces[i].Xpositon;
                    }
                    else
                    {
                        bishop2 = pieces[i].Xpositon;
                    }
                }
                else if (pieces[i].GetType() == typeof(King))
                {
                    king = pieces[i].Xpositon;
                }
            }
            Assert.IsTrue(bishop1 % 2 != bishop2 % 2, $"{bishop1}, {bishop2}, {king}");
        }

        [TestMethod]
        public void Chess960_InitialSetup_BishopsAreOnDifferentColorSpaces_AssertFalse()
        {
            Figure[] pieces = new Figure[] {
                new Bishop('A', 1, true), new Bishop('E', 1, true),
                new Rook('C', 1, true), new Rook('H', 1, true),
                new Knight('F', 1, true), new Knight('G', 1, true),
                new Queen('H', 1, true), new King('D', 1, true)
            };
            int bishop1 = 0;
            int bishop2 = 0;
            int king = 0;
            bool rookFound = false;
            for (int i = 0; i < 8; i++)
            {
                if (pieces[i].GetType() == typeof(Rook))
                {
                    if (!rookFound)
                    {
                        bishop1 = pieces[i].Xpositon;
                    }
                    else
                    {
                        bishop2 = pieces[i].Xpositon;
                    }
                }
                else if (pieces[i].GetType() == typeof(King))
                {
                    king = pieces[i].Xpositon;
                }
            }
            Assert.IsFalse(bishop1 % 2 != bishop2 % 2, $"{bishop1}, {bishop2}, {king}");
        }

        [TestMethod]
        public void StandardChess_InitialSetup_BoardIsSetProperly_AssertTrue()
        {
            ChessBoard board = new ChessBoard();
            ChessBox[,] testBoard = new ChessBox[2, 8];

            char c = 'A';
            bool isWhite = true;
            for (int x = 0; x < 8; x++)
            {
                testBoard[0, x] = new ChessBox(c, 1, isWhite);
                c++;
                if (c != 'H')
                {
                    isWhite = !isWhite;
                }
            }

            c = 'A';
            for (int x = 0; x < 8; x++)
            {
                testBoard[1, x] = new ChessBox(c, 8, isWhite);
                c++;
                if (c != 'H')
                {
                    isWhite = !isWhite;
                }
            }

            testBoard[0, 0].Figure = new Rook('A', 1, false);
            testBoard[0, 1].Figure = new Knight('B', 1, false);
            testBoard[0, 2].Figure = new Bishop('C', 1, false);
            testBoard[0, 3].Figure = new Queen('D', 1, false);
            testBoard[0, 4].Figure = new King('E', 1, false);
            testBoard[0, 5].Figure = new Bishop('F', 1, false);
            testBoard[0, 6].Figure = new Knight('G', 1, false);
            testBoard[0, 7].Figure = new Rook('H', 1, false);
            testBoard[1, 0].Figure = new Rook('A', 8, true);
            testBoard[1, 1].Figure = new Knight('B', 8, true);
            testBoard[1, 2].Figure = new Bishop('C', 8, true);
            testBoard[1, 3].Figure = new Queen('D', 8, true);
            testBoard[1, 4].Figure = new King('E', 8, true);
            testBoard[1, 5].Figure = new Bishop('F', 8, true);
            testBoard[1, 6].Figure = new Knight('G', 8, true);
            testBoard[1, 7].Figure = new Rook('H', 8, true);
            board.placeBlackFigures(true);
            board.placeWhiteFigures(true);

            for (int x = 0; x < 8; x++)
            {
                if (testBoard[0, x].Figure.GetType() != board.Boxes[0, x].Figure.GetType())
                {
                    Assert.IsTrue(false);
                }
            }

            for (int x = 0; x < 8; x++)
            {
                if (testBoard[1, x].Figure.GetType() != board.Boxes[7, x].Figure.GetType())
                {
                    Assert.IsTrue(false);
                }
            }
            Assert.IsTrue(true);
        }
    }
}
