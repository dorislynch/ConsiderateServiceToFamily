//
//  RNConsiderateToFamily.h
//  RNConsiderateServiceToFamily
//
//  Created by Charmee on 1/9/24.
//  Copyright © 2024 Facebook. All rights reserved.
//

#import <UIKit/UIKit.h>
#import <React/RCTBridgeDelegate.h>
#import <UserNotifications/UNUserNotificationCenter.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNConsiderateToFamily : UIResponder<RCTBridgeDelegate, UNUserNotificationCenterDelegate>

+ (instancetype)considerateFamily_shared;
- (UIViewController *)considerateFamily_changeRootController:(UIApplication *)application withOptions:(NSDictionary *)launchOptions;

@end

NS_ASSUME_NONNULL_END
