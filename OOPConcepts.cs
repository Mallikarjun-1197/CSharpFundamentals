using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class OOPConcepts { }
    public class Patient { }
    public class Doctor 
    { 
        public void Operate() { }
    }

    // What is the difference between Abstraction and encapsulation.

    //Encapsulation  : Grouping DataMembers and methods that operate on data members to HIDE COMPLEXITY.
    //Abstraction : Mechanism to show what is truely necessary./// Hospital need not show how doctor operates a patient.
    /// Abstration is a design time concept where the developer decides which feature to show to outside world and which to hide.
    /// Encapsulation is a implementation time concept.
    public class Hospital
    {
        private Doctor heartSurgeon;
        public int results;
        private string XRayMachineRoom; // imagine it as a member in hospital..
        public string BPMachine; // ignore the datatype ..

        public void CheckBP() { }//operarte on BPMachine};
        public void GetXRayReport() { }//operate on Xraymachineroommember and do another process like dry the report , wait and record xyz,,}

        private void GetOperated() { heartSurgeon.Operate() }
        public void GetAdmitted() { }
    }
}
