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
      //  cost 1    n+1                 n
      //      c1    c2                 c3
      for(var i=0; i<array_IN.Length; i++){
        // termination
        // cost        n (because of < comparison, n+1 if =<)
        //             c4
        if(targetIndex == array_IN[i]){
          // cost 0 ???
          return i; //returns the index of the first entry in the array that matches targetIndex
        }
      }
      // cost 1
      return -1; // negative number = targetIndex doesn't exist in this array
      // Total = c1 + c2(n+1) + c3n + c4n + 1
      //         c1 + c2n +c2 + c3n + c4n + 1 // unwind
      //         c2n + c3n + c4n + c1+ c2 + 1 // group
      //         n(c2 + c3 + c4) + c1+ c2 + 1 // factor out n
      //    10,000 -----10------   --100-   1 // value heatmap, n * 10,000 higher order of growth...n is dominant value
      //    n2 -> n -> log(n)
    }

  }
}
