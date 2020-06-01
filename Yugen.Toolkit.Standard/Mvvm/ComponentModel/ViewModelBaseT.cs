﻿namespace Yugen.Toolkit.Standard.Mvvm.ComponentModel
{
    /// <summary>
    /// A base class for viewmodels.
    /// </summary>
    public abstract class ViewModelBase<T> : ViewModelBase where T : class, new()
    {
        public T Model;

        public ViewModelBase(T model = null)
        {
            Model = model ?? new T();
        }

        public static implicit operator T(ViewModelBase<T> model) => model.Model;
    }
}