import config from '../config.develop';

function fetchAll() {
    return fetch(`${config.apiRoot}/users`, {
        cache: 'no-cache',
        headers: {
            'Content-Type': 'application/json'
        }
    }).then(response => response.json());
}

function fetchProjects(userId) {
    return fetch(`${config.apiRoot}/users/${userId}/assignments`, {
        cache: 'no-cache',
        headers: {
            'Content-Type': 'application/json'
        }
    }).then(response => response.json());
}


export {
    fetchAll,
    fetchProjects
}
