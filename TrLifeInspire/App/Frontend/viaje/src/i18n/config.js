import i18n from 'i18next';
import { initReactI18next } from 'react-i18next';
import store from '../store'


const state = store.getState();
console.log(state)

i18n.use(initReactI18next).init({
    fallbackLng: state.settings.language,
    lng: state.settings.language,
    resources: {
        en: {
            translations: require('./locales/en/translations.json')
        },
        ar: {
            translations: require('./locales/ar/translations.json')
        }
    },
    ns: ['translations'],
    defaultNS: 'translations'
});

i18n.languages = ['en', 'ar'];

export default i18n;