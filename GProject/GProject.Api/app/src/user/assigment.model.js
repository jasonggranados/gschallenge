import moment from 'moment';

// maps an assigment from the server into an assigment model to be used on the client
function toModel(assigment) {
  const {
    assignedDate,
    credits,
    endDate,
    isActive,
    projectId,
    startDate
  } = assigment;

  return {
    projectId,
    credits,
    isActive,
    assignedDate: moment(assignedDate),
    startDate: moment(startDate),
    endDate: moment(endDate),
    status: isActive ? 'Active' : 'Inactive',
    daysToStart:  moment(startDate).diff(assignedDate, 'days')
  };
}

export {
  toModel
}
