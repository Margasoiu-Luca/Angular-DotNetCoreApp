import { CrudInterface } from "./CrudInterface";
import { HttpClient, HttpStatusCode } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Producator } from "src/Models/Producator";
import { ProducatorDTO } from "src/Models/Producatordto";

@Injectable()
export class CategorieProdusCrud implements CrudInterface<Producator,number>{
    get(id: number): Observable<Producator> {
        throw new Error("Method not implemented.");
    }
    getAll(): Observable<Producator[]> {
        throw new Error("Method not implemented.");
    }
    create(entity: Producator): Observable<HttpStatusCode> {
        throw new Error("Method not implemented.");
    }
    update(entity: Producator, id: number): Observable<HttpStatusCode> {
        throw new Error("Method not implemented.");
    }
    delete(id: number): Observable<HttpStatusCode> {
        throw new Error("Method not implemented.");
    }
}