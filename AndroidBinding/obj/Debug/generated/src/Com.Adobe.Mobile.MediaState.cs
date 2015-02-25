using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Adobe.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']"
	[global::Android.Runtime.Register ("com/adobe/mobile/MediaState", DoNotGenerateAcw=true)]
	public sealed partial class MediaState : global::Java.Lang.Object {


		static IntPtr ad_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='ad']"
		[Register ("ad")]
		public bool Ad {
			get {
				if (ad_jfieldId == IntPtr.Zero)
					ad_jfieldId = JNIEnv.GetFieldID (class_ref, "ad", "Z");
				return JNIEnv.GetBooleanField (Handle, ad_jfieldId);
			}
			set {
				if (ad_jfieldId == IntPtr.Zero)
					ad_jfieldId = JNIEnv.GetFieldID (class_ref, "ad", "Z");
				JNIEnv.SetField (Handle, ad_jfieldId, value);
			}
		}

		static IntPtr clicked_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='clicked']"
		[Register ("clicked")]
		public bool Clicked {
			get {
				if (clicked_jfieldId == IntPtr.Zero)
					clicked_jfieldId = JNIEnv.GetFieldID (class_ref, "clicked", "Z");
				return JNIEnv.GetBooleanField (Handle, clicked_jfieldId);
			}
			set {
				if (clicked_jfieldId == IntPtr.Zero)
					clicked_jfieldId = JNIEnv.GetFieldID (class_ref, "clicked", "Z");
				JNIEnv.SetField (Handle, clicked_jfieldId, value);
			}
		}

		static IntPtr complete_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='complete']"
		[Register ("complete")]
		public bool Complete {
			get {
				if (complete_jfieldId == IntPtr.Zero)
					complete_jfieldId = JNIEnv.GetFieldID (class_ref, "complete", "Z");
				return JNIEnv.GetBooleanField (Handle, complete_jfieldId);
			}
			set {
				if (complete_jfieldId == IntPtr.Zero)
					complete_jfieldId = JNIEnv.GetFieldID (class_ref, "complete", "Z");
				JNIEnv.SetField (Handle, complete_jfieldId, value);
			}
		}

		static IntPtr eventFirstTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='eventFirstTime']"
		[Register ("eventFirstTime")]
		public bool EventFirstTime {
			get {
				if (eventFirstTime_jfieldId == IntPtr.Zero)
					eventFirstTime_jfieldId = JNIEnv.GetFieldID (class_ref, "eventFirstTime", "Z");
				return JNIEnv.GetBooleanField (Handle, eventFirstTime_jfieldId);
			}
			set {
				if (eventFirstTime_jfieldId == IntPtr.Zero)
					eventFirstTime_jfieldId = JNIEnv.GetFieldID (class_ref, "eventFirstTime", "Z");
				JNIEnv.SetField (Handle, eventFirstTime_jfieldId, value);
			}
		}

		static IntPtr length_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='length']"
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

		static IntPtr mediaEvent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='mediaEvent']"
		[Register ("mediaEvent")]
		public string MediaEvent {
			get {
				if (mediaEvent_jfieldId == IntPtr.Zero)
					mediaEvent_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaEvent", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mediaEvent_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mediaEvent_jfieldId == IntPtr.Zero)
					mediaEvent_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaEvent", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mediaEvent_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr milestone_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='milestone']"
		[Register ("milestone")]
		public int Milestone {
			get {
				if (milestone_jfieldId == IntPtr.Zero)
					milestone_jfieldId = JNIEnv.GetFieldID (class_ref, "milestone", "I");
				return JNIEnv.GetIntField (Handle, milestone_jfieldId);
			}
			set {
				if (milestone_jfieldId == IntPtr.Zero)
					milestone_jfieldId = JNIEnv.GetFieldID (class_ref, "milestone", "I");
				JNIEnv.SetField (Handle, milestone_jfieldId, value);
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='name']"
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

		static IntPtr offset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='offset']"
		[Register ("offset")]
		public double Offset {
			get {
				if (offset_jfieldId == IntPtr.Zero)
					offset_jfieldId = JNIEnv.GetFieldID (class_ref, "offset", "D");
				return JNIEnv.GetDoubleField (Handle, offset_jfieldId);
			}
			set {
				if (offset_jfieldId == IntPtr.Zero)
					offset_jfieldId = JNIEnv.GetFieldID (class_ref, "offset", "D");
				JNIEnv.SetField (Handle, offset_jfieldId, value);
			}
		}

		static IntPtr offsetMilestone_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='offsetMilestone']"
		[Register ("offsetMilestone")]
		public int OffsetMilestone {
			get {
				if (offsetMilestone_jfieldId == IntPtr.Zero)
					offsetMilestone_jfieldId = JNIEnv.GetFieldID (class_ref, "offsetMilestone", "I");
				return JNIEnv.GetIntField (Handle, offsetMilestone_jfieldId);
			}
			set {
				if (offsetMilestone_jfieldId == IntPtr.Zero)
					offsetMilestone_jfieldId = JNIEnv.GetFieldID (class_ref, "offsetMilestone", "I");
				JNIEnv.SetField (Handle, offsetMilestone_jfieldId, value);
			}
		}

		static IntPtr openTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='openTime']"
		[Register ("openTime")]
		public global::Java.Util.Date OpenTime {
			get {
				if (openTime_jfieldId == IntPtr.Zero)
					openTime_jfieldId = JNIEnv.GetFieldID (class_ref, "openTime", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, openTime_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (openTime_jfieldId == IntPtr.Zero)
					openTime_jfieldId = JNIEnv.GetFieldID (class_ref, "openTime", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, openTime_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr percent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='percent']"
		[Register ("percent")]
		public double Percent {
			get {
				if (percent_jfieldId == IntPtr.Zero)
					percent_jfieldId = JNIEnv.GetFieldID (class_ref, "percent", "D");
				return JNIEnv.GetDoubleField (Handle, percent_jfieldId);
			}
			set {
				if (percent_jfieldId == IntPtr.Zero)
					percent_jfieldId = JNIEnv.GetFieldID (class_ref, "percent", "D");
				JNIEnv.SetField (Handle, percent_jfieldId, value);
			}
		}

		static IntPtr playerName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='playerName']"
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

		static IntPtr segment_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='segment']"
		[Register ("segment")]
		public string Segment {
			get {
				if (segment_jfieldId == IntPtr.Zero)
					segment_jfieldId = JNIEnv.GetFieldID (class_ref, "segment", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, segment_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (segment_jfieldId == IntPtr.Zero)
					segment_jfieldId = JNIEnv.GetFieldID (class_ref, "segment", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, segment_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr segmentLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='segmentLength']"
		[Register ("segmentLength")]
		public double SegmentLength {
			get {
				if (segmentLength_jfieldId == IntPtr.Zero)
					segmentLength_jfieldId = JNIEnv.GetFieldID (class_ref, "segmentLength", "D");
				return JNIEnv.GetDoubleField (Handle, segmentLength_jfieldId);
			}
			set {
				if (segmentLength_jfieldId == IntPtr.Zero)
					segmentLength_jfieldId = JNIEnv.GetFieldID (class_ref, "segmentLength", "D");
				JNIEnv.SetField (Handle, segmentLength_jfieldId, value);
			}
		}

		static IntPtr segmentNum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/field[@name='segmentNum']"
		[Register ("segmentNum")]
		public int SegmentNum {
			get {
				if (segmentNum_jfieldId == IntPtr.Zero)
					segmentNum_jfieldId = JNIEnv.GetFieldID (class_ref, "segmentNum", "I");
				return JNIEnv.GetIntField (Handle, segmentNum_jfieldId);
			}
			set {
				if (segmentNum_jfieldId == IntPtr.Zero)
					segmentNum_jfieldId = JNIEnv.GetFieldID (class_ref, "segmentNum", "I");
				JNIEnv.SetField (Handle, segmentNum_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/adobe/mobile/MediaState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaState); }
		}

		internal MediaState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getEventType;
		static IntPtr id_setEventType_I;
		protected int EventType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()I", "GetGetEventTypeHandler")]
			get {
				if (id_getEventType == IntPtr.Zero)
					id_getEventType = JNIEnv.GetMethodID (class_ref, "getEventType", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getEventType);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/method[@name='setEventType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEventType", "(I)V", "GetSetEventType_IHandler")]
			set {
				if (id_setEventType_I == IntPtr.Zero)
					id_setEventType_I = JNIEnv.GetMethodID (class_ref, "setEventType", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setEventType_I, new JValue (value));
			}
		}

		static IntPtr id_getTimePlayed;
		static IntPtr id_setTimePlayed_D;
		protected double TimePlayed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/method[@name='getTimePlayed' and count(parameter)=0]"
			[Register ("getTimePlayed", "()D", "GetGetTimePlayedHandler")]
			get {
				if (id_getTimePlayed == IntPtr.Zero)
					id_getTimePlayed = JNIEnv.GetMethodID (class_ref, "getTimePlayed", "()D");
				return JNIEnv.CallDoubleMethod  (Handle, id_getTimePlayed);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/method[@name='setTimePlayed' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setTimePlayed", "(D)V", "GetSetTimePlayed_DHandler")]
			set {
				if (id_setTimePlayed_D == IntPtr.Zero)
					id_setTimePlayed_D = JNIEnv.GetMethodID (class_ref, "setTimePlayed", "(D)V");
				JNIEnv.CallVoidMethod  (Handle, id_setTimePlayed_D, new JValue (value));
			}
		}

		static IntPtr id_getTimePlayedSinceTrack;
		static IntPtr id_setTimePlayedSinceTrack_D;
		protected double TimePlayedSinceTrack {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/method[@name='getTimePlayedSinceTrack' and count(parameter)=0]"
			[Register ("getTimePlayedSinceTrack", "()D", "GetGetTimePlayedSinceTrackHandler")]
			get {
				if (id_getTimePlayedSinceTrack == IntPtr.Zero)
					id_getTimePlayedSinceTrack = JNIEnv.GetMethodID (class_ref, "getTimePlayedSinceTrack", "()D");
				return JNIEnv.CallDoubleMethod  (Handle, id_getTimePlayedSinceTrack);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/method[@name='setTimePlayedSinceTrack' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setTimePlayedSinceTrack", "(D)V", "GetSetTimePlayedSinceTrack_DHandler")]
			set {
				if (id_setTimePlayedSinceTrack_D == IntPtr.Zero)
					id_setTimePlayedSinceTrack_D = JNIEnv.GetMethodID (class_ref, "setTimePlayedSinceTrack", "(D)V");
				JNIEnv.CallVoidMethod  (Handle, id_setTimePlayedSinceTrack_D, new JValue (value));
			}
		}

		static IntPtr id_getTimestamp;
		protected double Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()D", "GetGetTimestampHandler")]
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()D");
				return JNIEnv.CallDoubleMethod  (Handle, id_getTimestamp);
			}
		}

		static IntPtr id_setOffset_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MediaState']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setOffset", "(D)V", "")]
		protected void SetOffset (double p0)
		{
			if (id_setOffset_D == IntPtr.Zero)
				id_setOffset_D = JNIEnv.GetMethodID (class_ref, "setOffset", "(D)V");
			JNIEnv.CallVoidMethod  (Handle, id_setOffset_D, new JValue (p0));
		}

	}
}
