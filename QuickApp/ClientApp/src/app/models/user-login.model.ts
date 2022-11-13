// =============================
// Email: kkdubey1989@gmail.com
// https://github.com/kkdubey
// =============================

export class UserLogin {
    constructor(userName?: string, password?: string, rememberMe?: boolean) {
        this.userName = userName;
        this.password = password;
        this.rememberMe = rememberMe;
    }

    userName: string;
    password: string;
    rememberMe: boolean;
}
