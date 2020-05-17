﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlingenRestaurant
{
    public class NewsBlock
    {
        public int NewsBlockId { get; set; }
        public string NewsBlockTitle { get; private set; }
        public string NewsBlockDescription { get; private set; }
        public string NewsBlockImage { get; private set; }

        public NewsBlock(string newsBlockTitle, string newsBlockDescription, string newsBlockImage)
        {
            NewsBlockTitle = newsBlockTitle;
            NewsBlockDescription = newsBlockDescription;
            NewsBlockImage = newsBlockImage;
        }
    }
}
