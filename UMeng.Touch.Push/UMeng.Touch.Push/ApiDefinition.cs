using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace UMeng.Touch.Push
{
    [Static] 
    partial interface Constants
    {
        // extern NSString *const kUMessageAliasTypeSina __attribute__((visibility("default")));
        [Field("kUMessageAliasTypeSina", "__Internal")]
        NSString kUMessageAliasTypeSina { get; }

        // extern NSString *const kUMessageAliasTypeTencent __attribute__((visibility("default")));
        [Field("kUMessageAliasTypeTencent", "__Internal")]
        NSString kUMessageAliasTypeTencent { get; }

        // extern NSString *const kUMessageAliasTypeQQ __attribute__((visibility("default")));
        [Field("kUMessageAliasTypeQQ", "__Internal")]
        NSString kUMessageAliasTypeQQ { get; }

        // extern NSString *const kUMessageAliasTypeWeiXin __attribute__((visibility("default")));
        [Field("kUMessageAliasTypeWeiXin", "__Internal")]
        NSString kUMessageAliasTypeWeiXin { get; }

        // extern NSString *const kUMessageAliasTypeBaidu __attribute__((visibility("default")));
        [Field("kUMessageAliasTypeBaidu", "__Internal")]
        NSString kUMessageAliasTypeBaidu { get; }

        // extern NSString *const kUMessageAliasTypeRenRen __attribute__((visibility("default")));
        [Field("kUMessageAliasTypeRenRen", "__Internal")]
        NSString kUMessageAliasTypeRenRen { get; }

        // extern NSString *const kUMessageAliasTypeKaixin __attribute__((visibility("default")));
        [Field("kUMessageAliasTypeKaixin", "__Internal")]
        NSString kUMessageAliasTypeKaixin { get; }

        // extern NSString *const kUMessageAliasTypeDouban __attribute__((visibility("default")));
        [Field("kUMessageAliasTypeDouban", "__Internal")]
        NSString kUMessageAliasTypeDouban { get; }

        // extern NSString *const kUMessageAliasTypeFacebook __attribute__((visibility("default")));
        [Field("kUMessageAliasTypeFacebook", "__Internal")]
        NSString kUMessageAliasTypeFacebook { get; }

        // extern NSString *const kUMessageAliasTypeTwitter __attribute__((visibility("default")));
        [Field("kUMessageAliasTypeTwitter", "__Internal")]
        NSString kUMessageAliasTypeTwitter { get; }

        // extern NSString *const kUMessageErrorDomain;
        [Field("kUMessageErrorDomain", "__Internal")]
        NSString kUMessageErrorDomain { get; }
    }

    // @interface UMessage : NSObject
    [BaseType(typeof(NSObject))]
    interface UMessage
    {
        // +(void)startWithAppkey:(NSString *)appKey launchOptions:(NSDictionary *)launchOptions;
        [Static]
        [Export("startWithAppkey:launchOptions:")]
        void StartWithAppkey(string appKey, NSDictionary launchOptions);

        // +(void)registerForRemoteNotificationTypes:(UIRemoteNotificationType)types __attribute__((availability(ios, introduced=3_0, deprecated=8_0)));
        [Introduced(PlatformName.iOS, 3, 0, message: "Please use registerRemoteNotificationAndUserNotificationSettings instead")]
        [Deprecated(PlatformName.iOS, 8, 0, message: "Please use registerRemoteNotificationAndUserNotificationSettings instead")]
        [Static]
        [Export("registerForRemoteNotificationTypes:")]
        void RegisterForRemoteNotificationTypes(UIRemoteNotificationType types);

        // +(void)registerRemoteNotificationAndUserNotificationSettings:(UIUserNotificationSettings *)notificationSettings __attribute__((availability(ios, introduced=8_0)));
        [Introduced(PlatformName.iOS, 8, 0)]
        [Static]
        [Export("registerRemoteNotificationAndUserNotificationSettings:")]
        void RegisterRemoteNotificationAndUserNotificationSettings(UIUserNotificationSettings notificationSettings);

        // +(void)unregisterForRemoteNotifications;
        [Static]
        [Export("unregisterForRemoteNotifications")]
        void UnregisterForRemoteNotifications();

        // +(void)registerDeviceToken:(NSData *)deviceToken;
        [Static]
        [Export("registerDeviceToken:")]
        void RegisterDeviceToken(NSData deviceToken);

        // +(void)didReceiveRemoteNotification:(NSDictionary *)userInfo;
        [Static]
        [Export("didReceiveRemoteNotification:")]
        void DidReceiveRemoteNotification(NSDictionary userInfo);

        // +(void)setLocation:(CLLocation *)location;
        [Static]
        [Export("setLocation:")]
        void SetLocation(CLLocation location);

        // +(void)setLogEnabled:(BOOL)value;
        [Static]
        [Export("setLogEnabled:")]
        void SetLogEnabled(bool value);

        // +(void)setBadgeClear:(BOOL)value;
        [Static]
        [Export("setBadgeClear:")]
        void SetBadgeClear(bool value);

        // +(void)setAutoAlert:(BOOL)value;
        [Static]
        [Export("setAutoAlert:")]
        void SetAutoAlert(bool value);

        // +(void)setChannel:(NSString *)channel;
        [Static]
        [Export("setChannel:")]
        void SetChannel(string channel);

        // +(void)setUniqueID:(NSString *)uniqueId;
        [Static]
        [Export("setUniqueID:")]
        void SetUniqueID(string uniqueId);

        // +(void)sendClickReportForRemoteNotification:(NSDictionary *)userInfo;
        [Static]
        [Export("sendClickReportForRemoteNotification:")]
        void SendClickReportForRemoteNotification(NSDictionary userInfo);

        // +(void)getTags:(void (^)(NSSet *, NSInteger, NSError *))handle;
        [Static]
        [Export("getTags:")]
        void GetTags(Action<NSSet, nint, NSError> handle);

        // +(void)addTag:(id)tag response:(void (^)(id, NSInteger, NSError *))handle;
        [Static]
        [Export("addTag:response:")]
        void AddTag(NSObject tag, Action<NSObject, nint, NSError> handle);

        // +(void)removeTag:(id)tag response:(void (^)(id, NSInteger, NSError *))handle;
        [Static]
        [Export("removeTag:response:")]
        void RemoveTag(NSObject tag, Action<NSObject, nint, NSError> handle);

        // +(void)removeAllTags:(void (^)(id, NSInteger, NSError *))handle;
        [Static]
        [Export("removeAllTags:")]
        void RemoveAllTags(Action<NSObject, nint, NSError> handle);

        // +(void)addAlias:(NSString *)name type:(NSString *)type response:(void (^)(id, NSError *))handle;
        [Static]
        [Export("addAlias:type:response:")]
        void AddAlias(string name, string type, Action<NSObject, NSError> handle);

        // +(void)setAlias:(NSString *)name type:(NSString *)type response:(void (^)(id, NSError *))handle;
        [Static]
        [Export("setAlias:type:response:")]
        void SetAlias(string name, string type, Action<NSObject, NSError> handle);

        // +(void)removeAlias:(NSString *)name type:(NSString *)type response:(void (^)(id, NSError *))handle;
        [Static]
        [Export("removeAlias:type:response:")]
        void RemoveAlias(string name, string type, Action<NSObject, NSError> handle);
    }
}
