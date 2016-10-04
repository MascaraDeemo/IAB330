using Microsoft.Azure.Mobile.Server;

namespace InTouch2CGService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}