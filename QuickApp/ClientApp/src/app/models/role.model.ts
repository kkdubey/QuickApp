// =============================
// Email: kkdubey1989@gmail.com
// https://github.com/kkdubey
// =============================

import { Permission } from './permission.model';


export class Role {

    constructor(name?: string, description?: string, permissions?: Permission[]) {

        this.name = name;
        this.description = description;
        this.permissions = permissions;
    }

    public id: string;
    public name: string;
    public description: string;
    public usersCount: number;
    public permissions: Permission[];
}
