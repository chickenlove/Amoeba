﻿using System.Reactive.Disposables;
using Omnius.Base;
using Reactive.Bindings;

namespace Amoeba.Interface
{
    class QuickFindControlViewModel : ManagerBase
    {
        public ReactiveProperty<bool> IsSearchingMode { get; private set; }
        public ReactiveProperty<string> Text { get; private set; }
        public ReactiveCommand StartSearchCommand { get; private set; }
        public ReactiveCommand EndSearchCommand { get; private set; }

        private CompositeDisposable _disposable = new CompositeDisposable();
        private volatile bool _disposed;

        public QuickFindControlViewModel()
        {
            this.Init();
        }

        private void Init()
        {
            this.IsSearchingMode = new ReactiveProperty<bool>();

            this.Text = new ReactiveProperty<string>();

            this.StartSearchCommand = new ReactiveCommand();
            this.StartSearchCommand.Subscribe(() => this.StartSearch());

            this.EndSearchCommand = new ReactiveCommand();
            this.EndSearchCommand.Subscribe(() => this.EndSearch());
        }

        private void StartSearch()
        {
            this.IsSearchingMode.Value = true;
        }

        private void EndSearch()
        {
            this.Text.Value = string.Empty;
            this.IsSearchingMode.Value = false;
        }

        protected override void Dispose(bool disposing)
        {
            if (_disposed) return;
            _disposed = true;

            if (disposing)
            {
                _disposable.Dispose();
            }
        }
    }
}