namespace Fantasy;


public partial class ErrorCode
{
    public const int Success = 0; // 成功(0)
    public const int Error_SessionInvaild = 100010000; // 会话无效(100010000)
    public const int Error_LoginFail= 100010001; // 登录失败(100010001)
    public const int Error_RoleNameInvalid= 100010002; // 角色名字不合法(100010002)
    public const int Error_Empty= 100010003; // 空(100010003)
    public const int Error_AccountExist= 100010004; // 账号已存在(100010004)
    
    public const int Error_CreateRoleNotFindAccountInfo = 100010054; // 未获取到账号信息，请重新登录(100010054)
    public const int Error_NameCheckIsUse = 100010055; // 名字已被占用(100010055)
    public const int Error_GetRoleListNotFindAccountInfo = 100010056; // 未获取到账号信息，请重新登录(100010056)
    public const int Error_GetRoleNotFind = 100010057; // 未获取角色，请重新登录(100010057)
    public const int H_C2G_RoleCreate_Handler_UnknownError = 100010108; // 创建角色失败(10106)
    public const int Error_IllegalLink = 100010109; // 非法链接(10109)
    public const int RoomFail_NotRoomInMonitor = 100010200; // 查找的房间并不存在(10200) 
    public const int RoomTimeOut = 100010201; // 房间超时(10201)
    public const int RoomTypeNotSupport = 100010202; // 房间类型不支持(10202)
    public const int RoomIsNull = 100010203; // 房间为空(10203)

    public const int MoveError = 100010204; // 移动异常(10204)
    public const int RankError_NotRankComponent = 100010205; // 排行榜异常，没有挂载排行榜组件(10205)
    public const int UnitError_ReapeatAdd = 100010206; // 单位异常，重复添加(10206)
    public const int RoomIsFull = 100010207; // 房间已满(10207)
    public const int RoomInGaming = 100010208; // 房间正在游戏中(10208)


    public const int ERR_SeatIndexError = 100010208; // 座位索引错误(10208)
    public const int ERR_SeatHasPlayer = 100010209; // 该座位已经有人(10209)

    public const int ERR_TeamFull = 100010210; // 队伍已满(10210)
    public const int ERR_TeamNotFind = 100010211; // 队伍未找到(10211)        
    public const int ERR_PlayerNotFind = 100010212; // 玩家未找到(10212)
    public const int ERR_PlayerAlreadyInTeam = 100010213; // 玩家已在队伍中(10213)

    public const int ERR_UserNotFind = 100010214; // 用户未找到(10214)
    public const int ERR_FriendNotExists = 100010215; // 好友不存在(10215)
    public const int ERR_SaveRoleFailed = 100010216; // 保存角色失败(10216)
}