﻿namespace Observer
{
    partial class WindowsObserver
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.console = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.console)).BeginInit();
            // 
            // console
            // 
            this.console.Log = "Application";
            this.console.Source = "Overseer";
            // 
            // WindowsObserver
            // 
            this.ServiceName = "Windows Observer";
            ((System.ComponentModel.ISupportInitialize)(this.console)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog console;
    }
}
