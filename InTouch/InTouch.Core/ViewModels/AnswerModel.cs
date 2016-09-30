using MvvmCross.Core.ViewModels;

namespace InTouch.Core.ViewModels
{
	public class AnswerModel
		: MvxViewModel
	{
		//the name of the person sending the request
		private string _requesteeName;
		public string RequesteeName{
			get { return _requesteeName; }
			set
			{
				_requesteeName = value;
			}
		//the message send with the request
		private string _requestMessage;
		public string RequestMessage
		{
			get { return _requestMessage; }
			set
			{
				_requestMessage = value;
			}
		}
		//a arrayList of the quick answers
		private ArrayList _quickAnswers;
		public ArrayList QuickAnswers
		{
			get( return _quickAnswers; }
			set
			{
				_quickAnswers = value;
			}
		}
		//your own status message
		private string _statusMessage;
		public string StatusMessage
		{
			get { return _statusMessage; }
			set
			{
				_statusMessage = value;
			}
		}
		//your location - PLACEHOLDER
		private string _location;
		public string Location
		{
			get { return _location; }
			set
			{
				_location = value;
			}
		}
		//send location bool
		private bool _sendLocation;
		public bool SendLocation
		{
			get { return _sendLocation; }
			set
			{
				_sendLocation = value;
			}
		}

	}