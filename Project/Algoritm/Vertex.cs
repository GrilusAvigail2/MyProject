#pragma warning disable IDE0005 // Using directive is unnecessary.
using System;
using System.Collections.Generic;
using System.Text;
#pragma warning restore IDE0005 // Using directive is unnecessary.

namespace Algoritm
{
    class Vertex
    {
        //מספר מזהה של צומת
        //public int VertexId { get;private set; }
        string Name { get; set; }

        //רשימת הצמתים שמתחברים לצומת הנוכחית
        public List<Vertex> ConectedVertex { get; private set; }
    }
}
