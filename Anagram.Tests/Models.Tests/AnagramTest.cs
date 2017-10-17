using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void IsAnagram_IsFunctionBeingCalled_ReturnFalse()
    {
      WordSet testObj = new WordSet("bAcoN","cat");
      Assert.AreEqual(false, testObj.PartialAnagram());
    }
    [TestMethod]
    public void IsAnagram_AreStringComparisonWorking_FalseCase()
    {
      WordSet testObj = new WordSet("bAcoN","baCOn");
      Assert.AreEqual(false, testObj.PartialAnagram());
    }
    [TestMethod]
    public void IsAnagram_AreStringComparisonWorking_TrueCase()
    {
      WordSet testObj = new WordSet("bAt","Tab");
      Assert.AreEqual(true, testObj.PartialAnagram());
    }
    [TestMethod]
    public void IsAnagram_PartialAnagramTest_TrueCase()
    {
      WordSet testObj = new WordSet("BaTTlE", "bAt");
      Assert.AreEqual(true, testObj.PartialAnagram());
    }
    [TestMethod]
    public void IsAnagram_PartialAnagramTest_FalseCase()
    {
      WordSet testObj = new WordSet("BaTTlE", "bAtTLes");
      Assert.AreEqual(false, testObj.PartialAnagram());
    }
    [TestMethod]
    public void IsAnagram_AreStringsBeingAddedToListProp()
    {
      List<string> someList = new List<string> {"acbd","cdab","adbc"};
      WordSet testObj = new WordSet("abcd",someList.ToArray());
      Assert.AreEqual(3, testObj.GetTargetList().Count);
    }

  }
}
