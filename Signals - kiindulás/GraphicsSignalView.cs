﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Signals
{
    
    public partial class GraphicsSignalView : UserControl, IView
    {
        public GraphicsSignalView()
        {
            InitializeComponent();
        }

             /// <summary>
        /// A dokumentum, melynek adatait a nézet megjeleníti.
        /// TODO: a típusa legyen a Document leszármazottunk.
        /// </summary>
        private Document document;

        public GraphicsSignalView(Document document)
        {
            InitializeComponent();
            this.document = document;
        }

        /// <summary>
        /// A View interfész Update műveletánek implementációja.
        /// </summary>
        public void Update()
        {
            Invalidate();
        }

        public Document GetDocument()
        {
            return document;
        }

        /// <summary>
        /// A UserControl.Paint felüldefiniálása, ebben rajzolunk.
        /// </summary>
       /* protected override void OnPaint(PaintEventArgs e)
        {
            signalValues.Value;

            e.Graphics.DrawRectangle(blackPen, rect);


        }*/
    }
}
