#pragma warning disable IDE0005 // Using directive is unnecessary.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#pragma warning restore IDE0005 // Using directive is unnecessary.

namespace Algoritm
{
    class Graph
    {
        //רשימת הצמתים בגרף
        List<Vertex> Vertexs { get; set; }

        //רשימת הקשתות בגרף
        List<Edge> Edges { get; set; }

        //מטריצת הצגת הגרף
        int[][] Matrix { get; set; }

        public Graph()
        {
            Matrix = new int[][]();
        }

        //פונקציית הוספת צומת
        public void AddVertex(Vertex v)
        {
            for (int i = 0; i < v.ConectedVertex.Count(); i++)
            {
                Matrix[v.VertexId][v.ConectedVertex[i].VertexId] = 1;
            }
            Console.WriteLine(Matrix);
        }

        //פונקציית מחיקת צומת
        public void RemoveVertex(Vertex v)
        {
            for (int i = 0; i < v.ConectedVertex.Count(); i++)
            {
                Matrix[v.VertexId][v.ConectedVertex[i].VertexId] = 0;
            }
            Console.WriteLine(Matrix);
        }
    }
}
