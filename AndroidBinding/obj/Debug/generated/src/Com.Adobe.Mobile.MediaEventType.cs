using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Adobe.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaEventType']"
	[global::Android.Runtime.Register ("com/adobe/mobile/MediaEventType", DoNotGenerateAcw=true)]
	public partial class MediaEventType : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaEventType']/field[@name='MediaEventTypeClick']"
		[Register ("MediaEventTypeClick")]
		public const int MediaEventTypeClick = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaEventType']/field[@name='MediaEventTypeClose']"
		[Register ("MediaEventTypeClose")]
		public const int MediaEventTypeClose = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaEventType']/field[@name='MediaEventTypeComplete']"
		[Register ("MediaEventTypeComplete")]
		public const int MediaEventTypeComplete = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaEventType']/field[@name='MediaEventTypeMonitor']"
		[Register ("MediaEventTypeMonitor")]
		public const int MediaEventTypeMonitor = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaEventType']/field[@name='MediaEventTypePlay']"
		[Register ("MediaEventTypePlay")]
		public const int MediaEventTypePlay = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaEventType']/field[@name='MediaEventTypeStop']"
		[Register ("MediaEventTypeStop")]
		public const int MediaEventTypeStop = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaEventType']/field[@name='MediaEventTypeTrack']"
		[Register ("MediaEventTypeTrack")]
		public const int MediaEventTypeTrack = (int) 4;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/adobe/mobile/MediaEventType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaEventType); }
		}

		protected MediaEventType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaEventType']/constructor[@name='MediaEventType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MediaEventType () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MediaEventType)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

	}
}
