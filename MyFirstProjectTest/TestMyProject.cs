

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirtProject;
using MyLibrary;


namespace MyFirtProjectTest
{
    [TestClass]
    public class MyStringsTest
    {
        public void IndexOfWithIndex_Valid(string subStr, string str, int startIndex)
        {
            Assert.AreEqual(str.IndexOf(subStr, startIndex),
                            MyLibrary.MyString.IndexOf(subStr, str, startIndex));
        }
        [TestMethod]
        public void TestIndexOfWithIndex_Valid()
        {
            this.IndexOfWithIndex_Valid("hello", "phrase hell", 2);
            this.IndexOfWithIndex_Valid("hello", "hello phrase", 3);
            this.IndexOfWithIndex_Valid("hello", " phrase", 4);
            this.IndexOfWithIndex_Valid("hello", "hell phrase", 4);
            this.IndexOfWithIndex_Valid("hello", "phrase hello", 0);
            this.IndexOfWithIndex_Valid("hello", "phrase hhello", 5);
            this.IndexOfWithIndex_Valid("hello", "hello ", 0);
            this.IndexOfWithIndex_Valid("hello", "hhello", 4);
            this.IndexOfWithIndex_Valid("hello", "phrase hhello phrase", 3);
            this.IndexOfWithIndex_Valid("", "hello phrase", 3);
            this.IndexOfWithIndex_Valid("", "", 0);
            this.IndexOfWithIndex_Valid("hello", "", 0);
        }

        public void IndexOf_Valid(string subStr, string str)
        {
            Assert.AreEqual(str.IndexOf(subStr),
                            MyLibrary.MyString.IndexOf(subStr, str));
        }

        [TestMethod]
        public void TestIndexOf_Valid()
        {
            this.IndexOf_Valid("hello", "phrase hell");
            this.IndexOf_Valid("hello", "hello phrase");
            this.IndexOf_Valid("hello", " phrase");
            this.IndexOf_Valid("hello", "hell phrase");
            this.IndexOf_Valid("hello", "hello phrase");
            this.IndexOf_Valid("hello", "phrase hello");
            this.IndexOf_Valid("hello", "phrase hhello");
            this.IndexOf_Valid("hello", "hello ");
            this.IndexOf_Valid("hello", "hhello");
            this.IndexOf_Valid("hello", "phrase hhello phrase");
            this.IndexOf_Valid("hello", "");
            this.IndexOf_Valid("", "hello phrase");
            this.IndexOf_Valid("", "");
        }

        public void StartsWith_valid(string subStr, string str)
        {
            Assert.AreEqual(str.StartsWith(subStr), MyLibrary.MyString.StartsWith(subStr, str));
        }
        [TestMethod]
        public void TestStartsWith_valid()
        {
            this.StartsWith_valid("hello", "hello phrase");
            this.StartsWith_valid("hello", " phrase");
            this.StartsWith_valid("hello", "hell phrase");
            this.StartsWith_valid("hello", "hello phrase");
            this.StartsWith_valid("hello", "phrase hello");
            this.StartsWith_valid("hello", "phrase hell");
            this.StartsWith_valid("hello", "phrase hhello");
            this.StartsWith_valid("hello", "hello");
            this.StartsWith_valid("hello", "hhello");
            this.StartsWith_valid("hello", "phrase hhello phrase");
            this.StartsWith_valid("hello", "");
            this.StartsWith_valid("", "hello phrase");
            this.StartsWith_valid("", "");
        }

        public void EndWith_valid(string subStr, string str)
        {
            Assert.AreEqual(str.EndsWith(subStr), MyLibrary.MyString.EndsWith(subStr, str));
        }

        [TestMethod]
        public void TestEndWith_valid()
        {
            this.EndWith_valid("hello", "hello phrase");
            this.EndWith_valid("hello", " phrase");
            this.EndWith_valid("hello", "hello phrase");
            this.EndWith_valid("hello", "phrase hell");
            this.EndWith_valid("hello", "phrase hhello");
            this.EndWith_valid("hello", "hello");
            this.EndWith_valid("hello", "hhello");
            this.EndWith_valid("hello", "phrase hhello phrase");
            this.EndWith_valid("hello", "");
            this.EndWith_valid("", "hello phrase");
            this.EndWith_valid("", "");
        }

        public void LastIndexOf_valid(string subStr, string str)
        {
            Assert.AreEqual(str.LastIndexOf(subStr),
                            MyLibrary.MyString.LastIndexOf(subStr, str));
        }

        [TestMethod]
        public void TestLastIndexOf_valid()
        {
            this.LastIndexOf_valid("hello", "phrase hell");
            this.LastIndexOf_valid("hello", "hello phrase");
            this.LastIndexOf_valid("hello", " phrase");
            this.LastIndexOf_valid("hello", "hell phrase");
            this.LastIndexOf_valid("hello", "hello phrase");
            this.LastIndexOf_valid("hello", "phrase hello");
            this.LastIndexOf_valid("hello", "phrase hhello");
            this.LastIndexOf_valid("hello", "hello ");
            this.LastIndexOf_valid("hello", "hhello");
            this.LastIndexOf_valid("hello", "phrase hhello phrase");
            this.LastIndexOf_valid("hello", "");
            this.LastIndexOf_valid("", "hello phrase");
            this.LastIndexOf_valid("", "");
        }

        public void LastIndexOfWithIndex_valid(string subStr, string str, int startIndex)
        {
            Assert.AreEqual(str.LastIndexOf(subStr, startIndex),
                            MyLibrary.MyString.LastIndexOf(subStr, str, startIndex));
        }

        [TestMethod]
        public void TestLastIndexOfWithIndex_valid()
        {
            this.LastIndexOfWithIndex_valid("hello", "phrase hell", 2);
            this.LastIndexOfWithIndex_valid("hello", "hello phrase", 3);
            this.LastIndexOfWithIndex_valid("hello", " phrase", 4);
            this.LastIndexOfWithIndex_valid("hello", "hell phrase", 4);
            this.LastIndexOfWithIndex_valid("hello", "phrase hello", 2);
            this.LastIndexOfWithIndex_valid("hello", "phrase hhello", 5);
            this.LastIndexOfWithIndex_valid("hello", "hello ", 3);
            this.LastIndexOfWithIndex_valid("hello", "hhello", 4);
            this.LastIndexOfWithIndex_valid("hello", "phrase hhello phrase", 3);
            this.LastIndexOfWithIndex_valid("", "hello phrase", 3);
            this.LastIndexOfWithIndex_valid("", "", 0);
            this.LastIndexOfWithIndex_valid("hello", "", 0);
        }

        public void SubString_valid(string str, int startIndex)
        {
            Assert.AreEqual(str.Substring(startIndex),
                            MyLibrary.MyString.SubString(str, startIndex));
        }

        [TestMethod]
        public void TestSubString_valid()
        {

            this.SubString_valid("This is my first Project.Hello world.how are you", 17);
            this.SubString_valid("This is my first Project.Hello world.how are you", 10);
            this.SubString_valid("you", 2);
            this.SubString_valid("This is my first Project.Hello world.how are you", 0);
        }

        public void SubStringWithLength_valid(string str, int startIndex, int length)
        {
            Assert.AreEqual(str.Substring(startIndex, length),
                            MyLibrary.MyString.SubString(str, startIndex, length));
        }

        [TestMethod]
        public void TestSubStringWithLength_valid()
        {
            this.SubStringWithLength_valid("This is my first Project Hello world how are you", 17, 5);
            this.SubStringWithLength_valid("This is myfirst Project Hello world how are you", 10, 2);
            this.SubStringWithLength_valid("howare you", 3, 1);
            this.SubStringWithLength_valid("", 0, 0);
            this.SubStringWithLength_valid("This is my first Project.Hello world how are you", 0, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SubStringWithLength_StarIndexMoreLength()
        {
            string str = "how are you";
            int startIndex = 11;
            int length = 1;
            MyLibrary.MyString.SubString(str, startIndex, length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SubStringWithLength_StarIndexMoreLesZero()
        {
            string str = "how are you";
            int startIndex = -1;
            int length = 1;
            MyLibrary.MyString.SubString(str, startIndex, length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SubStringWithLength_LengthMoreLength()
        {
            string str = "how are you";
            int startIndex = 5;
            int length = 7;
            MyLibrary.MyString.SubString(str, startIndex, length);
        }

        public void ArrayCompare_valid(string[] strArray1, string[] strArray2, bool real)
        {
            Assert.AreEqual(real, MyLibrary.MyString.ArrayCompare(strArray1, strArray2));
        }

        [TestMethod]
        public void TestArrayCompare_valid()
        {
            this.ArrayCompare_valid(new string[] { "hello", "world", "This", "Program" },
                                     new string[] { "hello", "world", "This", "Program" }, true);

            this.ArrayCompare_valid(new string[] { "hello", "world", "This", "Program" },
                                     new string[] { "hell ", "world", "This", "Program" }, false);

            this.ArrayCompare_valid(new string[] { "hello", "world", "", "Program" },
                                     new string[] { "hello", "world", "This", "Program" }, false);

            this.ArrayCompare_valid(new string[] { "", "s", "", "s" },
                                     new string[] { "s", "", "s", "" }, false);

            this.ArrayCompare_valid(new string[] { "", "", "", "" },
                                     new string[] { "", "", "" }, false);

            this.ArrayCompare_valid(new string[] { "", "", "" },
                                     new string[] { "", "", "" }, true);

            this.ArrayCompare_valid(new string[] { "hello", "world", "This", "Program" },
                                     new string[] { "he ll", "world", "This", "Program" }, false);

            this.ArrayCompare_valid(new string[] { "werw", "wrwer", "" },
                                     new string[] { "werw", "wrwer", "" }, true);
        }

        public void Split_valid(string delimiter, string str)
        {
            Assert.AreEqual(true, MyLibrary.MyString.ArrayCompare(
                            str.Split(new string[] { "," }, StringSplitOptions.None),
                            MyLibrary.MyString.Split(str, delimiter)));
        }

        [TestMethod]
        public void TestSplit_valid()
        {
            this.Split_valid(",", "Th,is ,is, my, s");
            this.Split_valid(",", "Th,is ,is, my,s fi,rst,s p,rogr,ams,  ");
            this.Split_valid(",", "  Th,is ,is, my,s fi,rst,s p,rogr,ams,");
            this.Split_valid(",", "");
            this.Split_valid(",", "T");
            this.Split_valid(",", "Th,is ,is, my,s fi,rst,s p,rogr,ams,");
            this.Split_valid(",", "Th,is ,is,, my,s fi,rst,s p,rogr,ams,");
            this.Split_valid(",", ",Th,is ,is, my,s fi,rst,s p,rogr,ams,");
            this.Split_valid(",", "This is mys firsts programs");
        }

        public void Join_valid(string delimiter, string[] arr)
        {
            Assert.AreEqual(String.Join(delimiter, arr), MyLibrary.MyString.Join(delimiter, arr));
        }

        [TestMethod]
        public void TestJoin_valid()
        {
            this.Join_valid("|", new string[] { "Th", "is ", "is", " my", "s fi", "rst", "s p", "rogr", "ams,", "" });

            this.Join_valid("|", new string[] { "Th", "is ", "", "", "s fi", "", "s p", "rogr", "ams,", "" });

            this.Join_valid("|", new string[] { "Th", "is ", "is", " my", "s fi", "rst", "s p", "rogr", "ams,", "" });

            this.Join_valid("|", new string[] { "", "", "", " my", "s fi", "rst", "s p", "rogr", "ams,", "" });

            this.Join_valid("|", new string[] { "", "", "" });

            this.Join_valid("|", new string[] { "Th", "is ", "is", " my", "s fi", "rst", "s p", "rogr", "ams," });

            this.Join_valid("|", new string[] { });
        }

        public void AddToArray_Valid(string[] strArray, string str, int index, string[] arr)
        {
            Assert.AreEqual(true, MyLibrary.MyString.ArrayCompare(arr, MyLibrary.MyString.AddToArray(strArray, str, index)));
        }

        [TestMethod]
        public void TestAddToArray_Valid()
        {
            this.AddToArray_Valid(new string[] { "this is", "cool" }, "interest", 1,
                                   new string[] { "this is", "interest", "cool" });

            this.AddToArray_Valid(new string[] { "this is", "cool" }, "interest", 0,
                                   new string[] { "interest", "this is", "cool" });

            this.AddToArray_Valid(new string[] { "this is", "cool" }, " ", 1,
                                   new string[] { "this is", " ", "cool" });

            this.AddToArray_Valid(new string[] { }, "this", 0,
                                   new string[] { "this" });

            this.AddToArray_Valid(new string[] { }, "", 0,
                                   new string[] { "" });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAddToArrayStartIndexMoreThanLength()
        {
            string[] strArray = new string[] { "this is", "cool" };
            string str = "interest";
            int index = 3;
            MyLibrary.MyString.AddToArray(strArray, str, index);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAddToArrayStartIndexMorelesZero()
        {
            string[] strArray = new string[] { "this is", "cool", "to do" };
            string str = "interest";
            int index = -1;
            MyLibrary.MyString.AddToArray(strArray, str, index);
        }

        public void DelFromArray_Valid(string[] strArray, int index, string[] arr)
        {
            Assert.AreEqual(true, MyLibrary.MyString.ArrayCompare(arr, MyLibrary.MyString.DelFromArray(strArray, index)));
        }

        [TestMethod]
        public void TestDelFromArray_Valid()
        {
            this.DelFromArray_Valid(new string[] { "this", "is", "my", "first", "steps", "in", "IT world" }, 3,
                                    new string[] { "this", "is", "my", "steps", "in", "IT world" });

            this.DelFromArray_Valid(new string[] { "", "is", "my", "first", "steps", "in", "IT world" }, 0,
                                     new string[] { "is", "my", "first", "steps", "in", "IT world" });

            this.DelFromArray_Valid(new string[] { "", "", "", "", "", "", "" }, 4,
                                     new string[] { "", "", "", "", "", "" });

            this.DelFromArray_Valid(new string[] { "this", "is", "my", "first", "steps", "in", "IT world" }, 6,
                                     new string[] { "this", "is", "my", "first", "steps", "in" });

            this.DelFromArray_Valid(new string[] { "this", "is", "my", "first", "steps", "in", "IT world" }, 5,
                                     new string[] { "this", "is", "my", "first", "steps", "IT world" });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDelFromArrayStartIndexMoreThanLength()
        {
            string[] strArray = new string[] { "", "is", "my", "first", "steps", "in", "IT world" };
            int index = 7;
            MyLibrary.MyString.DelFromArray(strArray, index);
        }

        [TestMethod]
        public void TestDelFromArrayStartIndexMorelesZero()
        {
            string[] strArray = new string[] { "This", "is", "my", "first", "steps", "in", "IT world" };
            int index = -2;
            try
            {
                MyLibrary.MyString.DelFromArray(strArray, index);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, MyLibrary.MyString.testmesag2);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }
    }

    [TestClass]
    public class MyArrayTest
    {
        public void ArraySortSelection_Void(int[] ArrayIn, int[] ArrayOut, bool real,
            MyLibrary.MyArraySortDirection direction = MyLibrary.MyArraySortDirection.LowToHight)
        {
            MyLibrary.MyArray.ArraySortSelection(ArrayIn, direction);
            Assert.AreEqual(real, MyLibrary.MyArray.ArrayCompareInt(ArrayIn, ArrayOut));
        }

        [TestMethod]
        public void TestArraySortSelection()
        {
            this.ArraySortSelection_Void(new int[] { 5, 7, 3, 9, 2, 4, 1, 6, 8 },
                                new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 },
                                true, MyLibrary.MyArraySortDirection.HightToLow);
        }

        [TestMethod]
        public void TestToArray_Valid()
        {
            Assert.AreEqual(true, MyLibrary.MyArray.ArrayCompareInt(
                MyLibrary.MyArray.ToArrayInt(1, 2, 3, 45, 3, 4, 7, 235, 2545, 4, 124, 745),
                new int[] { 1, 2, 3, 45, 3, 4, 7, 235, 2545, 4, 124, 745, })
            );
            Assert.AreEqual(true, MyLibrary.MyArray.ArrayCompareInt(
                MyLibrary.MyArray.ToArrayInt(),
                new int[] { })
            );
            Assert.AreEqual(true, MyLibrary.MyArray.ArrayCompareInt(
                MyLibrary.MyArray.ToArrayInt(1),
                new int[] { 1 })
            );
        }


        public void ArraySortMethod_Void(int[] arrayIn, int[] ArrayOut, bool real,
         MyArraySortDirection direction,
         ArraySortMethod sortmethod = ArraySortMethod.QuickSort)
        {
            MyArray.ArraySort(arrayIn, direction, sortmethod);
            Assert.AreEqual(real, MyArray.ArrayCompareInt(arrayIn, ArrayOut));
        }

        [TestMethod]
        public void TestSortMethod()
        {

            foreach (ArraySortMethod sortMethod in Enum.GetValues(typeof(ArraySortMethod)))
            {
                this.ArraySortMethod_Void(new int[] { 5, 7, 3, 9, 2, 4, 1, 6, 8 },
                    new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, true,
                    MyLibrary.MyArraySortDirection.LowToHight, sortMethod);
                this.ArraySortMethod_Void(new int[] { },
                    new int[] { }, true,
                    MyLibrary.MyArraySortDirection.LowToHight, sortMethod);
                this.ArraySortMethod_Void(new int[] { 5 },
                    new int[] { 5 }, true,
                    MyLibrary.MyArraySortDirection.LowToHight, sortMethod);
                this.ArraySortMethod_Void(new int[] { 5, 7, 3, 9, 2, 4, 1, 6, 8 },
                    new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, true,
                    MyLibrary.MyArraySortDirection.HightToLow, sortMethod);
            }
        }

    }

    [TestClass]
    public class MyMathTest
    {
        public void TestFactorial_Void(int v, int real)
        {

            Assert.AreEqual(real, MyLibrary.MyMath.Factorial(v));
        }

        [TestMethod]
        public void TestFactorial()
        {
            this.TestFactorial_Void(1, 1);
            this.TestFactorial_Void(2, 2);
            this.TestFactorial_Void(3, 6);
            this.TestFactorial_Void(4, 24);
            this.TestFactorial_Void(5, 120);
            this.TestFactorial_Void(6, 720);
            this.TestFactorial_Void(7, 5040);
            this.TestFactorial_Void(8, 40320);
            this.TestFactorial_Void(9, 362880);
            this.TestFactorial_Void(10, 3628800);

        }

        public void TestFibonachi_Void(int v, int real)
        {

            Assert.AreEqual(real, MyLibrary.MyMath.Fibonachi(v));
        }
        [TestMethod]
        public void TestFibonachi()
        {
            this.TestFibonachi_Void(1, 1);
            this.TestFibonachi_Void(2, 1);
            this.TestFibonachi_Void(3, 2);
            this.TestFibonachi_Void(4, 3);
            this.TestFibonachi_Void(5, 5);
            this.TestFibonachi_Void(6, 8);
            this.TestFibonachi_Void(7, 13);
            this.TestFibonachi_Void(8, 21);
            this.TestFibonachi_Void(9, 34);
            this.TestFibonachi_Void(10, 55);

        }
    }

    [TestClass]
    public class MyLinkedListTest
    {
        public MyLinkedList<T> ArrayToMyList<T>(T[] array)
        {
            var myList = new MyLinkedList<T>();
            foreach (T value in array)
            {
                myList.AddLast(value);
            }
            return myList;
        }

        public static bool ArrayCompare<T>(T[] Array1, T[] Array2)
        {
            if (Array1.Length != Array2.Length)
                return false;
            for (int i = 0; i < Array1.Length; i++)
                if (!(Array1[i].Equals(Array2[i])))
                {
                    return false;
                }
            return true;
        }

        private void ListCompare<T>(MyLinkedList<T> myList, T[] arrayOut)
        {
            Assert.AreEqual(true, ArrayCompare(myList.ToArray(), arrayOut));
        }

        [TestMethod]
        public void TestAddFirst()
        {
            var myList = ArrayToMyList(new int[] { 2, 7, 5 });
            myList.AddFirst(5);
            this.ListCompare(myList, new int[] { 5, 2, 7, 5 });


            myList = ArrayToMyList(new int[] { 5 });
            myList.AddFirst(2);
            this.ListCompare(myList, new int[] { 2,  5 });


            myList = ArrayToMyList(new int[] { });
            myList.AddFirst(7);
            this.ListCompare(myList, new int[] { 7 });

            var myListStr = ArrayToMyList(new string[] { "2", "7", "5" });
            myListStr.AddFirst("5");
            this.ListCompare(myListStr, new string[] { "5", "2", "7", "5" });


            myListStr = ArrayToMyList(new string[] { "5" });
            myListStr.AddFirst("2");
            this.ListCompare(myListStr, new string[] { "2", "5" });


            myListStr = ArrayToMyList(new string[] { });
            myListStr.AddFirst("7");
            this.ListCompare(myListStr, new string[] { "7" });


        }

        [TestMethod]
        public void TestAddLast()
        {
            var myList = ArrayToMyList(new int[] { 2, 7, 5 });
            myList.AddLast(6);
            this.ListCompare(myList, new int[] { 2, 7, 5, 6 });


            myList = ArrayToMyList(new int[] { 5 });
            myList.AddLast(2);
            this.ListCompare(myList, new int[] { 5, 2 });


            myList = ArrayToMyList(new int[] { });
            myList.AddLast(7);
            this.ListCompare(myList, new int[] { 7 });


            var myListStr = ArrayToMyList(new string[] { "2", "7", "5" });
            myListStr.AddLast("6");
            this.ListCompare(myListStr, new string[] { "2", "7", "5", "6" });


            myListStr = ArrayToMyList(new string[] { "5" });
            myListStr.AddLast("2");
            this.ListCompare(myListStr, new string[] { "5", "2" });


            myListStr = ArrayToMyList(new string[] { "" });
            myListStr.AddLast("");
            this.ListCompare(myListStr, new string[] { "","" });

            myListStr = ArrayToMyList(new string[] {  });
            myListStr.AddLast("");
            this.ListCompare(myListStr, new string[] { "" });
        }

        [TestMethod]
        public void TestAddAfter()
        {
            var myList = ArrayToMyList(new int[] { 2, 7, 5 });
            myList.AddAfter(myList.First, 6);
            this.ListCompare(myList, new int[] { 2, 6, 7, 5 });


            myList = ArrayToMyList(new int[] { 5 });
            myList.AddAfter(myList.First, 2);
            this.ListCompare(myList, new int[] { 5, 2 });


            var myListStr = ArrayToMyList(new string[] { "2", "7", "5" });
            myListStr.AddAfter(myListStr.First, "6");
            this.ListCompare(myListStr, new string[] { "2", "6", "7", "5" });


            myListStr = ArrayToMyList(new string[] { "5" });
            myListStr.AddAfter(myListStr.First, "2");
            this.ListCompare(myListStr, new string[] { "5", "2" });


            myListStr = ArrayToMyList(new string[] { "" });
            myListStr.AddAfter(myListStr.First, "");
            this.ListCompare(myListStr, new string[] { "", "" });

        }

        [TestMethod]
        public void TestRemove()
        {
            var myList = ArrayToMyList(new int[] { 2, 7, 5 });
            myList.Remove(5);
            this.ListCompare(myList, new int[] { 2, 7 });


            myList = ArrayToMyList(new int[] { 2, 7, 5 });
            myList.Remove(2);
            this.ListCompare(myList, new int[] { 7, 5 });


            myList = ArrayToMyList(new int[] { 2, 7, 5 });
            myList.Remove(7);
            this.ListCompare(myList, new int[] { 2, 5 });


            myList = ArrayToMyList(new int[] { 2, 7, 5 });
            myList.Remove(7);
            myList.Remove(5);
            this.ListCompare(myList, new int[] { 2 });


            myList = ArrayToMyList(new int[] { 2, 7, 5 });
            myList.Remove(7);
            myList.Remove(5);
            myList.Remove(2);
            this.ListCompare(myList, new int[] { });


            myList = ArrayToMyList(new int[] { 2, 3, 4, 5 });
            myList.Remove(3);
            myList.Remove(4);
            this.ListCompare(myList, new int[] { 2, 5 });


            myList = ArrayToMyList(new int[] { 1, 2, 3, 2 });
            myList.Remove(2);
            myList.Remove(2);
            this.ListCompare(myList, new int[] { 1, 3 });


            myList = ArrayToMyList(new int[] { 1, 1, 1, 1, 1 });
            myList.Remove(1);
            this.ListCompare(myList, new int[] { 1, 1, 1, 1 });


            myList = ArrayToMyList(new int[] { 5 });
            myList.Remove(5);
            this.ListCompare(myList, new int[] { });

            var myListStr = ArrayToMyList(new string[] { "2", "7", "5" });
            myListStr.Remove("5");
            this.ListCompare(myListStr, new string[] { "2", "7" });


            myListStr = ArrayToMyList(new string[] { "2", "7", "5" });
            myListStr.Remove("2");
            this.ListCompare(myListStr, new string[] { "7", "5" });


            myListStr = ArrayToMyList(new string[] { "2", "7", "5" });
            myListStr.Remove("7");
            this.ListCompare(myListStr, new string[] { "2", "5" });


            myListStr = ArrayToMyList(new [] { "2", "7", "5" });
            myListStr.Remove("7");
            myListStr.Remove("5");
            this.ListCompare(myListStr, new [] { "2" });


            myListStr = ArrayToMyList(new string[] { "2", "7", "5" });
            myListStr.Remove("7");
            myListStr.Remove("5");
            myListStr.Remove("2");
            this.ListCompare(myListStr, new string[] { });


            myListStr = ArrayToMyList(new string[] { "2", "3", "4", "5" });
            myListStr.Remove("3");
            myListStr.Remove("4");
            this.ListCompare(myListStr, new string[] { "2", "5" });


            myListStr = ArrayToMyList(new string[] { "1", "2", "3", "2" });
            myListStr.Remove("2");
            myListStr.Remove("2");
            this.ListCompare(myListStr, new string[] { "1", "3" });


            myListStr = ArrayToMyList(new string[] { "1", "1", "1", "1", "1" });
            myListStr.Remove("1");
            this.ListCompare(myListStr, new string[] { "1", "1", "1", "1"});


            myListStr = ArrayToMyList(new string[] { "5" });
            myListStr.Remove( "5");
            this.ListCompare(myListStr, new string[] {  });

        }

        [TestMethod]
        public void TestClear_Void()
        {
            var myList = ArrayToMyList(new int[] { 2, 7, 5 });
            myList.Clear();
            this.ListCompare(myList, new int[] { });


            myList = ArrayToMyList(new int[] { });
            myList.Clear();
            this.ListCompare(myList, new int[] {});

            myList = ArrayToMyList(new int[] { });
            myList.Clear();
            myList.Clear();
            this.ListCompare(myList, new int[] { });

            myList = ArrayToMyList(new int[] { 5 });
            myList.Remove(5);
            this.ListCompare(myList, new int[] { });

            var myListStr = ArrayToMyList(new string[] { "2", "7", "5" });
            myListStr.Clear();
            this.ListCompare(myListStr, new string[] {  });


            myListStr = ArrayToMyList(new string[] { });
            myListStr.Clear();
            this.ListCompare(myListStr, new string[] { });


            myListStr = ArrayToMyList(new string[] { "2" });
            myListStr.Clear();
            this.ListCompare(myListStr, new string[] { });


            myListStr = ArrayToMyList(new string[] { "2", "7", "5" });
            myListStr.Clear();
            myListStr.Clear();
            this.ListCompare(myListStr, new string[] { });
            
        }


    }
}
