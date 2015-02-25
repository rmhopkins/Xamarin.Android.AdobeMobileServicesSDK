using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Adobe.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']"
	[global::Android.Runtime.Register ("com/adobe/mobile/MediaSettings", DoNotGenerateAcw=true)]
	public partial class MediaSettings : global::Java.Lang.Object {


		static IntPtr CPM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='CPM']"
		[Register ("CPM")]
		public string Cpm {
			get {
				if (CPM_jfieldId == IntPtr.Zero)
					CPM_jfieldId = JNIEnv.GetFieldID (class_ref, "CPM", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, CPM_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CPM_jfieldId == IntPtr.Zero)
					CPM_jfieldId = JNIEnv.GetFieldID (class_ref, "CPM", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, CPM_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr channel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='channel']"
		[Register ("channel")]
		public string Channel {
			get {
				if (channel_jfieldId == IntPtr.Zero)
					channel_jfieldId = JNIEnv.GetFieldID (class_ref, "channel", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, channel_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (channel_jfieldId == IntPtr.Zero)
					channel_jfieldId = JNIEnv.GetFieldID (class_ref, "channel", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, channel_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr completeCloseOffsetThreshold_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='completeCloseOffsetThreshold']"
		[Register ("completeCloseOffsetThreshold")]
		public int CompleteCloseOffsetThreshold {
			get {
				if (completeCloseOffsetThreshold_jfieldId == IntPtr.Zero)
					completeCloseOffsetThreshold_jfieldId = JNIEnv.GetFieldID (class_ref, "completeCloseOffsetThreshold", "I");
				return JNIEnv.GetIntField (Handle, completeCloseOffsetThreshold_jfieldId);
			}
			set {
				if (completeCloseOffsetThreshold_jfieldId == IntPtr.Zero)
					completeCloseOffsetThreshold_jfieldId = JNIEnv.GetFieldID (class_ref, "completeCloseOffsetThreshold", "I");
				JNIEnv.SetField (Handle, completeCloseOffsetThreshold_jfieldId, value);
			}
		}

		static IntPtr isMediaAd_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='isMediaAd']"
		[Register ("isMediaAd")]
		public bool IsMediaAd {
			get {
				if (isMediaAd_jfieldId == IntPtr.Zero)
					isMediaAd_jfieldId = JNIEnv.GetFieldID (class_ref, "isMediaAd", "Z");
				return JNIEnv.GetBooleanField (Handle, isMediaAd_jfieldId);
			}
			set {
				if (isMediaAd_jfieldId == IntPtr.Zero)
					isMediaAd_jfieldId = JNIEnv.GetFieldID (class_ref, "isMediaAd", "Z");
				JNIEnv.SetField (Handle, isMediaAd_jfieldId, value);
			}
		}

		static IntPtr length_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='length']"
		[Register ("length")]
		public double Length {
			get {
				if (length_jfieldId == IntPtr.Zero)
					length_jfieldId = JNIEnv.GetFieldID (class_ref, "length", "D");
				return JNIEnv.GetDoubleField (Handle, length_jfieldId);
			}
			set {
				if (length_jfieldId == IntPtr.Zero)
					length_jfieldId = JNIEnv.GetFieldID (class_ref, "length", "D");
				JNIEnv.SetField (Handle, length_jfieldId, value);
			}
		}

		static IntPtr milestones_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='milestones']"
		[Register ("milestones")]
		public string Milestones {
			get {
				if (milestones_jfieldId == IntPtr.Zero)
					milestones_jfieldId = JNIEnv.GetFieldID (class_ref, "milestones", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, milestones_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (milestones_jfieldId == IntPtr.Zero)
					milestones_jfieldId = JNIEnv.GetFieldID (class_ref, "milestones", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, milestones_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, name_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr offsetMilestones_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='offsetMilestones']"
		[Register ("offsetMilestones")]
		public string OffsetMilestones {
			get {
				if (offsetMilestones_jfieldId == IntPtr.Zero)
					offsetMilestones_jfieldId = JNIEnv.GetFieldID (class_ref, "offsetMilestones", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, offsetMilestones_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (offsetMilestones_jfieldId == IntPtr.Zero)
					offsetMilestones_jfieldId = JNIEnv.GetFieldID (class_ref, "offsetMilestones", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, offsetMilestones_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr parentName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='parentName']"
		[Register ("parentName")]
		public string ParentName {
			get {
				if (parentName_jfieldId == IntPtr.Zero)
					parentName_jfieldId = JNIEnv.GetFieldID (class_ref, "parentName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, parentName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (parentName_jfieldId == IntPtr.Zero)
					parentName_jfieldId = JNIEnv.GetFieldID (class_ref, "parentName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, parentName_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr parentPod_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='parentPod']"
		[Register ("parentPod")]
		public string ParentPod {
			get {
				if (parentPod_jfieldId == IntPtr.Zero)
					parentPod_jfieldId = JNIEnv.GetFieldID (class_ref, "parentPod", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, parentPod_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (parentPod_jfieldId == IntPtr.Zero)
					parentPod_jfieldId = JNIEnv.GetFieldID (class_ref, "parentPod", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, parentPod_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr parentPodPosition_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='parentPodPosition']"
		[Register ("parentPodPosition")]
		public double ParentPodPosition {
			get {
				if (parentPodPosition_jfieldId == IntPtr.Zero)
					parentPodPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "parentPodPosition", "D");
				return JNIEnv.GetDoubleField (Handle, parentPodPosition_jfieldId);
			}
			set {
				if (parentPodPosition_jfieldId == IntPtr.Zero)
					parentPodPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "parentPodPosition", "D");
				JNIEnv.SetField (Handle, parentPodPosition_jfieldId, value);
			}
		}

		static IntPtr playerID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='playerID']"
		[Register ("playerID")]
		public string PlayerID {
			get {
				if (playerID_jfieldId == IntPtr.Zero)
					playerID_jfieldId = JNIEnv.GetFieldID (class_ref, "playerID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, playerID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (playerID_jfieldId == IntPtr.Zero)
					playerID_jfieldId = JNIEnv.GetFieldID (class_ref, "playerID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, playerID_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr playerName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='playerName']"
		[Register ("playerName")]
		public string PlayerName {
			get {
				if (playerName_jfieldId == IntPtr.Zero)
					playerName_jfieldId = JNIEnv.GetFieldID (class_ref, "playerName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, playerName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (playerName_jfieldId == IntPtr.Zero)
					playerName_jfieldId = JNIEnv.GetFieldID (class_ref, "playerName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, playerName_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr segmentByMilestones_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='segmentByMilestones']"
		[Register ("segmentByMilestones")]
		public bool SegmentByMilestones {
			get {
				if (segmentByMilestones_jfieldId == IntPtr.Zero)
					segmentByMilestones_jfieldId = JNIEnv.GetFieldID (class_ref, "segmentByMilestones", "Z");
				return JNIEnv.GetBooleanField (Handle, segmentByMilestones_jfieldId);
			}
			set {
				if (segmentByMilestones_jfieldId == IntPtr.Zero)
					segmentByMilestones_jfieldId = JNIEnv.GetFieldID (class_ref, "segmentByMilestones", "Z");
				JNIEnv.SetField (Handle, segmentByMilestones_jfieldId, value);
			}
		}

		static IntPtr segmentByOffsetMilestones_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='segmentByOffsetMilestones']"
		[Register ("segmentByOffsetMilestones")]
		public bool SegmentByOffsetMilestones {
			get {
				if (segmentByOffsetMilestones_jfieldId == IntPtr.Zero)
					segmentByOffsetMilestones_jfieldId = JNIEnv.GetFieldID (class_ref, "segmentByOffsetMilestones", "Z");
				return JNIEnv.GetBooleanField (Handle, segmentByOffsetMilestones_jfieldId);
			}
			set {
				if (segmentByOffsetMilestones_jfieldId == IntPtr.Zero)
					segmentByOffsetMilestones_jfieldId = JNIEnv.GetFieldID (class_ref, "segmentByOffsetMilestones", "Z");
				JNIEnv.SetField (Handle, segmentByOffsetMilestones_jfieldId, value);
			}
		}

		static IntPtr trackSeconds_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/field[@name='trackSeconds']"
		[Register ("trackSeconds")]
		public int TrackSeconds {
			get {
				if (trackSeconds_jfieldId == IntPtr.Zero)
					trackSeconds_jfieldId = JNIEnv.GetFieldID (class_ref, "trackSeconds", "I");
				return JNIEnv.GetIntField (Handle, trackSeconds_jfieldId);
			}
			set {
				if (trackSeconds_jfieldId == IntPtr.Zero)
					trackSeconds_jfieldId = JNIEnv.GetFieldID (class_ref, "trackSeconds", "I");
				JNIEnv.SetField (Handle, trackSeconds_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/adobe/mobile/MediaSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaSettings); }
		}

		protected MediaSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/constructor[@name='MediaSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MediaSettings () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MediaSettings)) {
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

		static IntPtr id_adSettingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/method[@name='adSettingsWith' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='double'] and parameter[7][@type='java.lang.String']]"
		[Register ("adSettingsWith", "(Ljava/lang/String;DLjava/lang/String;Ljava/lang/String;Ljava/lang/String;DLjava/lang/String;)Lcom/adobe/mobile/MediaSettings;", "")]
		public static global::Com.Adobe.Mobile.MediaSettings AdSettingsWith (string p0, double p1, string p2, string p3, string p4, double p5, string p6)
		{
			if (id_adSettingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_lang_String_ == IntPtr.Zero)
				id_adSettingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "adSettingsWith", "(Ljava/lang/String;DLjava/lang/String;Ljava/lang/String;Ljava/lang/String;DLjava/lang/String;)Lcom/adobe/mobile/MediaSettings;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			global::Com.Adobe.Mobile.MediaSettings __ret = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.MediaSettings> (JNIEnv.CallStaticObjectMethod  (class_ref, id_adSettingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5), new JValue (native_p6)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p6);
			return __ret;
		}

		static IntPtr id_settingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaSettings']/method[@name='settingsWith' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("settingsWith", "(Ljava/lang/String;DLjava/lang/String;Ljava/lang/String;)Lcom/adobe/mobile/MediaSettings;", "")]
		public static global::Com.Adobe.Mobile.MediaSettings SettingsWith (string p0, double p1, string p2, string p3)
		{
			if (id_settingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_settingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "settingsWith", "(Ljava/lang/String;DLjava/lang/String;Ljava/lang/String;)Lcom/adobe/mobile/MediaSettings;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			global::Com.Adobe.Mobile.MediaSettings __ret = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.MediaSettings> (JNIEnv.CallStaticObjectMethod  (class_ref, id_settingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

	}
}
