﻿using System;
using System.ComponentModel;

namespace ProcessVSTPlugin
{
	/// <summary>
	/// InvestigatedPluginPresetFileFormat is used to store information about what binary content that changes in a preset file.
	/// </summary>
	public class InvestigatedPluginPresetFileFormat : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		
		private int _indexInFile;
		private byte _byteValue;
		private string _parameterName;
		private string _parameterLabel;
		private string _parameterDisplay;
		
		public InvestigatedPluginPresetFileFormat(int indexInFile,
		                                          byte byteValue,
		                                          string parameterName,
		                                          string parameterLabel,
		                                          string parameterDisplay)
		{
			_indexInFile = indexInFile;
			_byteValue = byteValue;
			_parameterName = parameterName;
			_parameterLabel = parameterLabel;
			_parameterDisplay = parameterDisplay;
		}
		
		public int IndexInFile
		{
			get { return _indexInFile; }
			set {
				_indexInFile = value;
				this.NotifyPropertyChanged("IndexInFile");
			}
		}

		public byte ByteValue
		{
			get { return _byteValue; }
			set {
				_byteValue = value;
				this.NotifyPropertyChanged("ByteValue");
			}
		}

		public string ParameterName
		{
			get { return _parameterName; }
			set {
				_parameterName = value;
				this.NotifyPropertyChanged("ParameterName");
			}
		}

		public string ParameterLabel
		{
			get { return _parameterLabel; }
			set {
				_parameterLabel = value;
				this.NotifyPropertyChanged("ParameterLabel");
			}
		}

		public string ParameterDisplay
		{
			get { return _parameterDisplay; }
			set {
				_parameterDisplay = value;
				this.NotifyPropertyChanged("ParameterDisplay");
			}
		}

		private void NotifyPropertyChanged(string name)
		{
			if(PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(name));
		}
	}
}