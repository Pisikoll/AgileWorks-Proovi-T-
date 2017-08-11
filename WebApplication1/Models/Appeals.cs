using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models {
    public static class Appeals {
        static List<IAppeal> appeals = new List<IAppeal>();
        
        public static void AadAppeal(IAppeal appeal) {
            appeal.id = appeals.Count;
            appeals.Add(appeal);
            appeals = appeals.OrderBy(o => o.lahendamiseT2htAeg).ToList();
        }
        public static List<IAppeal> GetAllAppeals() {
            return appeals;
        }
        public static List<IAppeal> GetActiveAppeals() {
            return appeals.Where(m => m.onLahendatud == false).ToList();
        }
        public static void EndAppeal(int id) {
            IAppeal appeal = appeals.Find(i => i.id == id);
            appeal.onLahendatud = true;
            int index = appeals.IndexOf(appeal);
            appeals[index] = appeal;
        }
    };
}