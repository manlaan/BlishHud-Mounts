﻿using Blish_HUD.Controls;
using Blish_HUD;
using Blish_HUD.Graphics.UI;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using System.Linq;

namespace Manlaan.Mounts.Views
{
    class TestView : View
    {
        private readonly TextureCache textureCache;

        public TestView(TextureCache textureCache)
        {
            this.textureCache = textureCache;
        }

        protected override void Build(Container buildPanel)
        {
            foreach (int i in Enumerable.Range(1, 100).ToList())
            {
                Label l = new Label
                {
                    Text = "labelthing",
                    Location = new Point(30, i * 30),
                    Width = 800,
                    AutoSizeHeight = true,
                    WrapText = true,
                    Font = GameService.Content.DefaultFont18,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Parent = buildPanel
                };
            }            
        }
    }
}
