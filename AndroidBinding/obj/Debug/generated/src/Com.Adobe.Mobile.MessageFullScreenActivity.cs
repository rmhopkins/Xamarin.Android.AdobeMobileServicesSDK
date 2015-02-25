using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Adobe.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreenActivity']"
	[global::Android.Runtime.Register ("com/adobe/mobile/MessageFullScreenActivity", DoNotGenerateAcw=true)]
	public partial class MessageFullScreenActivity : global::Com.Adobe.Mobile.AdobeMarketingActivity {


		static IntPtr message_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreenActivity']/field[@name='message']"
		[Register ("message")]
		protected global::Com.Adobe.Mobile.MessageFullScreen Message {
			get {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Lcom/adobe/mobile/MessageFullScreen;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, message_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.MessageFullScreen> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Lcom/adobe/mobile/MessageFullScreen;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, message_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/adobe/mobile/MessageFullScreenActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageFullScreenActivity); }
		}

		protected MessageFullScreenActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreenActivity']/constructor[@name='MessageFullScreenActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MessageFullScreenActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MessageFullScreenActivity)) {
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
