﻿using cSharpExpert.Framework;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace cSharpExpert.GameObjects
{
    public class Star : GameObject
    {
        private Transform transform;
        private SpriteRenderer spriteRenderer;
        public Star(SpriteRenderer _renderer, Transform _transfrom, GraphicsDeviceManager _graphics) : base(_renderer, _transfrom, _graphics)
        {
        }
    }
}
