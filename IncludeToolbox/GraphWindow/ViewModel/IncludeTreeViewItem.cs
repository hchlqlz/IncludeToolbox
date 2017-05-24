﻿using System.Collections.Generic;

namespace IncludeToolbox.GraphWindow
{
    public abstract class IncludeTreeViewItem : PropertyChangedBase
    {
        public string Name { get; protected set; }

        public string AbsoluteFilename { get; protected set; }

        /// <summary>
        /// List of children, builds tree lazily.
        /// </summary>
        public abstract IReadOnlyList<IncludeTreeViewItem> Children { get; }

        static protected IReadOnlyList<IncludeTreeViewItem> emptyList = new IncludeTreeViewItem[0];

        public IncludeTreeViewItem()
        {
        }

        protected void NotifyAllPropertiesChanged()
        {
            OnNotifyPropertyChanged(nameof(Name));
            OnNotifyPropertyChanged(nameof(Children));
            OnNotifyPropertyChanged(nameof(AbsoluteFilename));
        }
    }
}
