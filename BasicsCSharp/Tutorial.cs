﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    // Classes are an encapsulation of data properties and data methods.
    // Properties - describe the data the class will be holding.
    // Methods - identifies which operations can be performed on the data.
    //
    //
    // Access modifiers define the visibility of a class property and/or methods.
    // 3 types of access modifiers: Private, Public and Protected
    //
    // Private: members from that class cannot be accessed from any external program
    // Protected: those members can only be accessed by classes inherited from the current class.
    //

    class Tutorial
    {
        // Defining the fields of the class
        int TutorialID;
        string TutorialName;

        //This is a constructor: used to initialize values. Should have the same name of the class.
        public Tutorial()   // Access modifier always public and no return type.
        {
            TutorialID = 0;
            TutorialName = "Default";
        }

        // Defining the SetTutorial method
        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }

        public string GetTutorial()
        {
            return TutorialName;
        }
    }
}
