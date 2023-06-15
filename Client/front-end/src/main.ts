/// <reference types="@angular/localize" />

import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { createMap } from '@automapper/core';
import { Producator } from './Models/Producator';
import { ProducatorDTO } from './Models/Producatordto';
import { MapperService } from './app/services/Mapper';


console.log("test")
platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));
