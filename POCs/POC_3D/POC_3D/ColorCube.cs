﻿using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_3D
{
    public class ColorCube : Cube
    {
        Vector3 Color = new Vector3(1, 1, 1);

        public ColorCube(Vector3 color) : base()
        {
            Color = color;
        }

        public override Vector3[] GetColorData()
        {
            return new Vector3[] {
            Color,
            Color,
            Color,
            Color,
            Color,
            Color,
            Color,
            Color
        };
        }
    }
}
