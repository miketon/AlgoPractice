using System;

namespace AlgoPractice {

  class MainClass {
    public static void Main (string[] args) {
      Console.WriteLine ("Hello World!");

      int[] testList = {5, 8, 3, 7, 5, 1, 31, 12, 5};

      Console.WriteLine("Index of value 7 {0}", findIndexOf(testList, 7));
      Console.WriteLine("Index of value 5 {0}", findIndexOf(testList, 5));
      Console.WriteLine("Index of value 13511 {0}", findIndexOf(testList, 13511));
    }

    // Linear Search
    private static int findIndexOf(int[] array_IN, int targetIndex){
      for(var i=0; i<array_IN.Length; i++){
        if(targetIndex == array_IN[i]){
          return i; //returns the index of the first entry in the array that matches targetIndex
        }
      }
      return -1; // negative number = targetIndex doesn't exist in this array
    }

  }
}
