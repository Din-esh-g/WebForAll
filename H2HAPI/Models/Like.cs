using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewProjectAPI.Models
{
  public class Like
  {
    public int LikerId { get; set; }
    public int LikeeId { get; set; }
    public virtual Users Liker { get; set; }
    public virtual Users Likee { get; set; }
  
   


  }
}
