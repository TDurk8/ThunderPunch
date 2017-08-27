using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderPunch
{
    public class Permissions
    {
        private bool _editPermissions=false;
        private bool _editUserInfo = false;
        private bool _viewReports = false;
        private bool _editSocialMedia = false;
        private bool _editPunches = false;
        private string _name;
        private string _originalPermission;
        private string _updatedPermission;

        public bool EditPermissions { get => _editPermissions; set => _editPermissions = value; }
        public bool EditUserInfo { get => _editUserInfo; set => _editUserInfo = value; }
        public bool ViewReports { get => _viewReports; set => _viewReports = value; }
        public bool EditSocialMedia { get => _editSocialMedia; set => _editSocialMedia = value; }
        public bool EditPunches { get => _editPunches; set => _editPunches = value; }
        public string OriginalPermission { get => _originalPermission; set => _originalPermission = value; }
        public string UpdatedPermission { get => _updatedPermission; set => _updatedPermission = value; }
        public string Name { get => _name; set => _name = value; }

        public Permissions(String original,String updated)
        {
            this._originalPermission = original;
            this.UpdatedPermission = updated;
        }
        public Permissions(String name)
        {
            this.Name = name;
        }
    }
}
