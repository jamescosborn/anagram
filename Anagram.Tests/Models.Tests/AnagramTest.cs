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
      Assert.AreEqual(false, testObj.IsAnagram());
    }
    [TestMethod]
    public void IsAnagram_AreStringComparisonWorking_FalseCase()
    {
      WordSet testObj = new WordSet("bAcoN","baCOn");
      Assert.AreEqual(false, testObj.IsAnagram());
    }
    [TestMethod]
    public void IsAnagram_AreStringComparisonWorking_TrueCase()
    {
      WordSet testObj = new WordSet("bAt","Tab");
      Assert.AreEqual(true, testObj.IsAnagram());
    }
  }
}
