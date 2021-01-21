using RadioProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioProject.Entities.Concrete
{
    public class Post :IEntity
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public override string ToString()
        {
            return $"{PostId,-10} {Title,-10} {Details,-10}";
        }
    }
}
