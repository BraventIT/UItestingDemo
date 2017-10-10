#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#define DEBUG 1
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <WebKit/WebKit.h>
#import <SafariServices/SafariServices.h>
#import <QuartzCore/QuartzCore.h>
#import <CloudKit/CloudKit.h>
#import <Intents/Intents.h>

@class __MonoMac_NSActionDispatcher;
@class __MonoMac_NSAsyncActionDispatcher;
@class UIKit_UIControlEventProxy;
@class AppDelegate;
@class HomeViewController;
@class LastViewController;
@class UItestCloudExample_iOS_TestDataSource;
@class MidleViewController;
@class __UIGestureRecognizerToken;
@class __UIGestureRecognizerParameterlessToken;
@class __UIGestureRecognizerParametrizedToken;
@class __NSObject_Disposer;
@class __UILongPressGestureRecognizer;
@class __UIPanGestureRecognizer;
@class __UIPinchGestureRecognizer;
@class __UIRotationGestureRecognizer;
@class __UITapGestureRecognizer;
@class __UISwipeGestureRecognizer;
@class __UIScreenEdgePanGestureRecognizer;
@class Plugin_Share_ShareActivityItemSource;

@interface AppDelegate : NSObject<UIApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
	-(void) applicationWillResignActive:(UIApplication *)p0;
	-(void) applicationDidEnterBackground:(UIApplication *)p0;
	-(void) applicationWillEnterForeground:(UIApplication *)p0;
	-(void) applicationDidBecomeActive:(UIApplication *)p0;
	-(void) applicationWillTerminate:(UIApplication *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface HomeViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnEntrar;
	@property (nonatomic, assign) UILabel * lblPass;
	@property (nonatomic, assign) UILabel * lblTItle;
	@property (nonatomic, assign) UILabel * lblUser;
	@property (nonatomic, assign) UITextField * txfPass;
	@property (nonatomic, assign) UITextField * txfUser;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnEntrar;
	-(void) setBtnEntrar:(UIButton *)p0;
	-(UILabel *) lblPass;
	-(void) setLblPass:(UILabel *)p0;
	-(UILabel *) lblTItle;
	-(void) setLblTItle:(UILabel *)p0;
	-(UILabel *) lblUser;
	-(void) setLblUser:(UILabel *)p0;
	-(UITextField *) txfPass;
	-(void) setTxfPass:(UITextField *)p0;
	-(UITextField *) txfUser;
	-(void) setTxfUser:(UITextField *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface LastViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnBack;
	@property (nonatomic, assign) UILabel * lblTItle;
	@property (nonatomic, assign) UITableView * table;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnBack;
	-(void) setBtnBack:(UIButton *)p0;
	-(UILabel *) lblTItle;
	-(void) setLblTItle:(UILabel *)p0;
	-(UITableView *) table;
	-(void) setTable:(UITableView *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface MidleViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnIrTabla;
	@property (nonatomic, assign) UILabel * lbliPhone;
	@property (nonatomic, assign) UILabel * lblTitle;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnIrTabla;
	-(void) setBtnIrTabla:(UIButton *)p0;
	-(UILabel *) lbliPhone;
	-(void) setLbliPhone:(UILabel *)p0;
	-(UILabel *) lblTitle;
	-(void) setLblTitle:(UILabel *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface __UIGestureRecognizerToken : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface __UIGestureRecognizerParameterlessToken : __UIGestureRecognizerToken {
}
	-(void) target;
@end

@interface __UIGestureRecognizerParametrizedToken : __UIGestureRecognizerToken {
}
	-(void) target:(UIGestureRecognizer *)p0;
@end


