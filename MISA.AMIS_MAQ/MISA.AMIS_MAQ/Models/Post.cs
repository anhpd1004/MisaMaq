using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.AMIS_MAQ.Models
{
    public class Post
    {
        /// <summary>
        /// Post id
        /// </summary>
        public int PostID { get; set; }
        /// <summary>
        /// customerID
        /// </summary>
        public int CustomerID { get; set; }
        /// <summary>
        /// like id
        /// </summary>
        public int LikeID { get; set; }
        /// <summary>
        /// comment id
        /// </summary>
        public int CommentID { get; set; }
        /// <summary>
        /// nội dung bài post
        /// </summary>
        public string PostContent { get; set; }
    }
}