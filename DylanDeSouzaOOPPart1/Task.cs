using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Numerics;
using Windows.Graphics;
using Windows.Graphics.Printing.PrintSupport;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace DylanDeSouzaOOPPart1
{
    class Task
    {
        string description;
        string notes;
        bool isComplete;
        string name;
        readonly DateTime? created;

        public Task(string name, string description, bool isComplete, string notes = null)
        {
            this.created = DateTime.Now;
            if (string.IsNullOrEmpty(description)) Console.WriteLine("Description cannot be null or empty.");
            else this.description = description;
            this.isComplete = isComplete;
            this.notes = notes;
            this.name = name;
        }

        public bool IsComplete { get { return isComplete; } }

        public void ToggleCompleteStatus() => isComplete = !isComplete;
    }
}