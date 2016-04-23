using System;

namespace AlgoPractice {

  class MainClass {

    public static void Main (string[] args) {
      Console.WriteLine ("Hello World!");
      LinearSearch();
    }

    private static void LinearSearch(){
      int[] intList = {5, 8, 3, 7, 5, 1, 31, 12, 5}; 
      
      int indexofTheValue7     = findIndexOf(intList, 7)    ; // returns 3
      int indexofTheValue5     = findIndexOf(intList, 5)    ; // returns 0 first instance of 5, not last
      int indexofTheValue13511 = findIndexOf(intList, 13511); // returns -1; 13511 doesn't exist in the list

      Console.WriteLine("Index of value 7 {0}", indexofTheValue7);
      Console.WriteLine("Index of value 5 {0}", indexofTheValue5);
      Console.WriteLine("Index of value 13511 {0}", indexofTheValue13511);
    }

    // Linear Search
    // Invariant has an : init, maintenance, and termination. True for algorithm, one of which is a for loop.
    private static int findIndexOf(int[] array_IN, int targetIndex){
      //  init        termination     maintenance
      for(var i=0; i<array_IN.Length; i++){
        // termination
        if(targetIndex == array_IN[i]){
          return i; //returns the index of the first entry in the array that matches targetIndex
        }
      }
      return -1; // negative number = targetIndex doesn't exist in this array
    }

  }
}
